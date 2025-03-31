

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default,in T23 t23Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,in t23Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    
	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription queryDescription, in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default,in T23 t23Component = default,in T24 t24Component = default)
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
			if (archetype.EntityCount == 0 || archetype.Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,in t23Component,in t24Component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}

		EntityInfo.EnsureCapacity(Capacity);
	}

    
    }
