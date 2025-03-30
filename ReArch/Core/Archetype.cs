using System;
using System.Diagnostics;

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
	public ChunkArray[] Components { get; }
	public int EntitiesPerChunk { get; }
	public Signature Signature { get; }
	public BitSet BitSet { get; }
	
	public int EntityCount
	{
		get;
		internal set;
	}

	internal Archetype(Signature signature, int entityCountInChunk, int initialCapacity)
	{
		Signature = signature;
		EntitiesPerChunk = entityCountInChunk;
		Entities = new ChunkArray<Entity>(entityCountInChunk, initialCapacity);
		Components = new ChunkArray[signature.Count];
		int i = 0;
		foreach (var componentType in signature.Components)
		{
			var componentChunkArray = ArrayRegistry.GetArray(componentType, entityCountInChunk, initialCapacity);
			Components [i] = componentChunkArray;
			i++;
		}

		// The bitmask/set
		BitSet = signature.ToBitSet();
		_componentIdToArrayIndex = signature.Components.ToLookupArray();
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
	
	// TODO: public Enumerator<Chunk> GetEnumerator()
	// TODO: internal ChunkRangeIterator GetRangeIterator(int from, int to)

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

	// internal void Set(ref Slot slot, in object cmp)
	
	// bool Has(ComponentType type)
	
	// internal object? Get(scoped ref Slot slot, ComponentType type)
	
}

public sealed partial class Archetype
{

	// internal static void Copy(Archetype source, Archetype destination)
	
	// internal static void CopyComponents(Archetype from, ref int fromIndex, Archetype to, ref int toIndex)

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

	public void TrimExcess()
	{
		Entities.TrimExcess();
		foreach (var component in Components)
		{
			component.TrimExcess();
		}
	}

}