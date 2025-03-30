using System;

using Arch.Core.Extensions.Internal;

using Collections.Pooled;

using ReArch.Core.Utils;

namespace ReArch.Core;

public class Archetypes : IDisposable
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

public class Archetype
{
	private readonly int[] _componentIdToArrayIndex;
	
	internal int[] LookupArray => _componentIdToArrayIndex;

	public ChunkArray<Entity> Entities { get; }
	public ChunkArray[] Components { get; }
	public int EntitiesPreChunk { get; }
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
		EntitiesPreChunk = entityCountInChunk;
		Entities = new ChunkArray<Entity>(entityCountInChunk, initialCapacity);
		Components = new ChunkArray[signature.Count];
		int i = 0;
		foreach (var componentType in signature.Components)
		{
			var componentChunkArray = new ChunkArray(componentType.ByteSize, entityCountInChunk, initialCapacity);
			Components [i] = componentChunkArray;
			i++;
		}

		// The bitmask/set
		BitSet = signature.ToBitSet();
		_componentIdToArrayIndex = signature.Components.ToLookupArray();
	}

	// TODO: Implement
	// Add Entity
	// Add All Entities
	// Remove Entity
	// Get Entity
	// Has Component
	// GetComponent

}