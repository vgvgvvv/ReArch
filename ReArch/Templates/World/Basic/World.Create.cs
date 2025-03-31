

// TODO: Move create with T0 into world.cs?

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{


    [StructuralChange]
    public Entity Create<T0>(in T0 t0Component = default)
        where T0 : unmanaged
    {
        var signature = Component<T0>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0>(entity, out var slot, in t0Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1>(in T0 t0Component = default,in T1 t1Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
    {
        var signature = Component<T0, T1>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1>(entity, out var slot, in t0Component,in t1Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var signature = Component<T0, T1, T2>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2>(entity, out var slot, in t0Component,in t1Component,in t2Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var signature = Component<T0, T1, T2, T3>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var signature = Component<T0, T1, T2, T3, T4>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var signature = Component<T0, T1, T2, T3, T4, T5>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var signature = Component<T0, T1, T2, T3, T4, T5, T6>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }


    [StructuralChange]
    public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default,in T23 t23Component = default)
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
        var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>.Signature;

        // Create new entity and put it to the back of the array
        GetOrCreateNextEntity(out var entity);

        // Add to archetype & mapping
        var archetype = GetOrCreateArchetype(signature);
        var allocatedEntities = archetype.Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(entity, out var slot, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,in t23Component);

        // Resize map & Array to fit all potential new entities
        Capacity += allocatedEntities;
        EntityInfo.EnsureCapacity(Capacity);

        // Map
        EntityInfo.Add(entity.Id, archetype, slot);

        return entity;
    }
}


