using System;

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
	
	public Slice<Archetype> AsSpan()
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

public class Archetype
{
	private readonly int[] _componentIdToArrayIndex;

}