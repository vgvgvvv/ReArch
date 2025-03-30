using System;

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
	
	// TODO:  public void AddAll(Span<Entity> entities, int amount)
	// TODO: internal void Remove(int index, out int movedEntityId)
	// TODO: internal ref Entity GetEntity(scoped ref int index)
	// TODO: internal int Add<T>(Entity entity, out Slot slot, in T? cmp = default)
	// TODO:  internal void Set<T>(ref int index, in T? cmp)
	// TODO: public bool Has<T>()
	// TODO: internal ref T Get<T>(scoped ref Slot slot)
	// TODO: internal void SetRange<T>(in Slot from, in Slot to, in T? component = default)
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

	private bool EnsureCapacity(int capacity)
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

	private void TrimExcess()
	{
		Entities.TrimExcess();
		foreach (var component in Components)
		{
			component.TrimExcess();
		}
	}

}