using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Arch.Core.Extensions.Internal;

using Collections.Pooled;

using ReArch.Core.Utils;

namespace ReArch.Core;

public sealed class Archetypes : IDisposable
{

	private int _hashCode;
	public PooledList<Archetype> Items {  get; }
	
	public Archetypes(int capacity)
	{
		Items = new PooledList<Archetype>(capacity, ClearMode.Never);
		_hashCode = -1;
	}
	
	public int Count => Items.Count;

	public void Add(Archetype archetype)
	{
		Items.Add(archetype);
		_hashCode = -1;
		GetHashCode();
	}
	
	public void Remove(Archetype archetype)
	{
		Items.Remove(archetype);
		_hashCode = -1;
		GetHashCode();
	}
	
	public Span<Archetype> AsSpan()
	{
		return Items.Span;
	}
	
	public Archetype this[int index]
	{
		get => Items[index];
		set => Items[index] = value;
	}
	
	public bool Equals(Archetypes other)
	{
		return Items.Equals(other.Items);
	}
	
	public override bool Equals(object? obj)
	{
		return obj is Archetypes other && Equals(other);
	}
	
	public override int GetHashCode()
	{
		// Cached hashcode, return
		if (_hashCode != -1)
		{
			return _hashCode;
		}

		// Calculate and cache hashcode
		var hash = 17;
		foreach (var item in Items)
		{
			hash = (hash * 31) + (item?.GetHashCode() ?? 0);
		}

		_hashCode = hash;
		return hash;
	}
	
	public void Clear()
	{
		Items.Clear();
	}

	/// <summary>
	///     Disposes this instance.
	/// </summary>
	public void Dispose()
	{
		Items.Dispose();
	}

}

public sealed unsafe partial  class Archetype
{
	private readonly int[] _componentIdToArrayIndex;
	
	internal int[] LookupArray => _componentIdToArrayIndex;

	public ChunkArray<Entity> Entities { get; }
	public int EntityCapacity => Entities.Capacity;
	public ChunkArray[] Components { get; }
	public int EntitiesPerChunk { get; }
	public Signature Signature { get; }
	public BitSet BitSet { get; }
	
	public int EntityCount
	{
		get;
		internal set;
	}

	internal Archetype(Signature signature, int entityCountInChunk, int initialChunkCount)
	{
		Signature = signature;
		EntitiesPerChunk = entityCountInChunk;
		Entities = new ChunkArray<Entity>(entityCountInChunk, initialChunkCount);
		Components = new ChunkArray[signature.Count];
		int i = 0;
		foreach (var componentType in signature.Components)
		{
			var componentChunkArray = ArrayRegistry.GetArray(componentType, entityCountInChunk, initialChunkCount);
			Components [i] = componentChunkArray;
			i++;
		}

		// The bitmask/set
		BitSet = signature.ToBitSet();
		_componentIdToArrayIndex = signature.Components.ToLookupArray();
	}

	public ChunkArray GetComponents(Type type)
	{
		if (!ComponentRegistry.TryGet(type, out var componentType))
		{
			throw new Exception($"cannot find component type {componentType}");
		}
		return Components[_componentIdToArrayIndex[componentType.Id]];
	}

	public ChunkArray GetComponents(ComponentType type)
	{
		var index = _componentIdToArrayIndex[type.Id];
		if (index == -1)
		{
			throw new Exception("Component not found in archetype");
		}
		return Components[index];
	}

	public bool TryGetComponents(ComponentType type, out ChunkArray chunkArray)
	{
		var index = _componentIdToArrayIndex[type.Id];
		if (index == -1)
		{
			chunkArray = null;
			return false;
		}
		chunkArray = Components[index];
		return true;
	}
	
	public ChunkArray<T> GetComponents<T>() where T : unmanaged
	{
		var componentTypeId = Component<T>.ComponentType.Id;
		return (ChunkArray<T>) Components[_componentIdToArrayIndex[componentTypeId]];
	}

	internal int Add(Entity entity, out int index)
	{
		EntityCount++;
		bool alloced = EnsureCapacity(EntityCount);
		index = Entities.Add(entity);
		foreach (var component in Components)
		{
			component.AddDefault();
		}
		return alloced ? EntitiesPerChunk : 0;
	}
	
	
	public void AddAll(Slice<Entity> entities, int amount)
	{
		EnsureCapacity(EntityCount + amount);
		Entities.AddRange(entities);
		foreach (var chunkArray in Components)
		{
			chunkArray.AddRangeDefault(entities.Length);
#if DEBUG
			Debug.Assert(chunkArray.Count == EntityCount);
#endif
		}
		EntityCount += amount;
	}

	internal void Remove(int index, out int movedEntityId)
	{
		if(index < 0 || index > EntityCount)
			throw new ArgumentOutOfRangeException(nameof(index));

		Entities.Remove(index);
		EntityCount--;
		foreach (var chunkArray in Components)
		{
			chunkArray.Remove(index);
#if DEBUG
			Debug.Assert(chunkArray.Count == EntityCount);
#endif
		}

		if(index == EntityCount)
		{
			movedEntityId = -1;
		}
		else
		{
			movedEntityId = Entities[index].Id;
		}
	}

	internal ref Entity GetEntity(int index)
	{
		return ref Entities [index];
	}

	internal int Add<T>(Entity entity, out int index, in T cmp = default) where T : unmanaged
	{
		var createdChunk = Add(entity, out index);
		GetComponents<T>() [index] = cmp;
		return createdChunk;
	}

	internal void Set<T>(ref int index, in T cmp) where T : unmanaged
	{
		GetComponents<T>() [index] = cmp;
	}

	public bool Has<T>() where T : unmanaged
	{
		var id = Component<T>.ComponentType.Id;
		return BitSet.IsSet(id);
	}

	internal ref T Get<T>(scoped ref int index) where T : unmanaged
	{
		if (index < 0 || index >= EntityCount)
			throw new IndexOutOfRangeException();
		return ref GetComponents<T>() [index];
	}

	internal void SetRange<T>(in int start, in int count, in T component = default) where T : unmanaged
	{
		GetComponents<T>().SetRange(start, count, component);
	}
	
	public void Clear()
	{
		EntityCount = 0;
		Entities.Clear();
		foreach (var chunkArray in Components)
		{
			chunkArray.Clear();
		}
	}
}

public sealed unsafe partial class Archetype
{

	internal void Set(ref int index, in object cmp)
	{
		if(index > EntityCount)
			throw new ArgumentOutOfRangeException(nameof(index));
		if (!ComponentRegistry.TryGet(cmp.GetType(), out var componentType))
		{
			throw new Exception($"Cannot find component type {componentType.Type}");
		}
		var chunkArray = GetComponents(componentType);
		var byteSize = componentType.ByteSize;
		byte* ptr = stackalloc byte[componentType.ByteSize];
		Marshal.StructureToPtr(cmp, new IntPtr(ptr), false);
		chunkArray.Set(index, new Slice<byte>(ptr, byteSize)) ;
	}

	public bool Has(ComponentType type)
	{
		var id = type.Id;
		return BitSet.IsSet(id);
	}

	internal object? Get(int index, ComponentType type)
	{
		if (!Has(type))
		{
			return null;
		}
		var chunkArray = GetComponents(type);
		var byteSize = type.ByteSize;
		byte* ptr = stackalloc byte[byteSize];
		chunkArray.Get(index, new Slice<byte>(ptr, byteSize));
		return Marshal.PtrToStructure(new IntPtr(ptr), type.Type);
	}
	

}

public sealed partial class Archetype
{

	internal static void CopyOverwrite(Archetype source, Archetype destination, int destinationIndex)
	{
		var oldCount = destination.EntityCount;
		var newCount = destinationIndex + source.EntityCount;
		destination.EnsureCapacity(destinationIndex + source.EntityCount);
		destination.AddRangeDefault(newCount - oldCount);
		ChunkArray.Copy(source.Entities, 0, destination.Entities, destinationIndex, source.EntityCount);
		CopyComponents(source, 0, destination, destinationIndex);
	}

	internal static void CopyAfter(Archetype source, Archetype destination)
	{
		CopyOverwrite(source, destination, destination.EntityCount);
	}

	internal static void CopyComponents(Archetype from, int fromIndex, Archetype to, int toIndex)
	{
		foreach (var componentType in from.Signature.Components)
		{
			var fromComponents = from.GetComponents(componentType);
			if (!to.TryGetComponents(componentType, out var toComponents))
			{
				continue;
			}
			ChunkArray.Copy(fromComponents, fromIndex, toComponents, toIndex, from.EntityCount);
		}
	}

}

public sealed partial class Archetype
{

	public bool EnsureCapacity(int capacity)
	{
		if(Entities.Capacity < capacity)
		{
			Entities.EnsureCapacity(capacity);
			foreach (var component in Components)
			{
				component.EnsureCapacity(capacity);
			}
			return false;
		}
		return true;
	}

	public void AddRangeDefault(int amount)
	{
		Entities.AddRangeDefault(amount);
		foreach (var component in Components)
		{
			component.AddRangeDefault(amount);
		}
		EntityCount += amount;
#if DEBUG
		Debug.Assert(Entities.Count == EntityCount);
		foreach (var component in Components)
		{
			Debug.Assert(component.Count == EntityCount);
		}
#endif
	}

	public void TrimExcess()
	{
		Entities.TrimExcess();
		foreach (var component in Components)
		{
			component.TrimExcess();
		}
#if DEBUG
		Debug.Assert(Entities.Count == EntityCount);
		foreach (var component in Components)
		{
			Debug.Assert(component.Count == EntityCount);
		}
#endif
	}

}