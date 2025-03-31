

using System;
using System.Runtime.CompilerServices;
using ReArch.Core;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    

[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription queryDescription)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
        where T24 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    }
