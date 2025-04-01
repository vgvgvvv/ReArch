
// TODO: Move query with T0 into world.cs?

namespace ReArch.Core;
public partial class World
{

     public void InlineEntityQuery<T, T0>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0>
        where T0 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1>
        where T0 : unmanaged
        where T1 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            var t20Components = archetype.GetComponents<T20>();
            var t20ComponentsEnumerator = t20Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext() && t20ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current, ref t20ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            var t20Components = archetype.GetComponents<T20>();
            var t20ComponentsEnumerator = t20Components.GetEnumerator();
            var t21Components = archetype.GetComponents<T21>();
            var t21ComponentsEnumerator = t21Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext() && t20ComponentsEnumerator.MoveNext() && t21ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current, ref t20ComponentsEnumerator.Current, ref t21ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            var t20Components = archetype.GetComponents<T20>();
            var t20ComponentsEnumerator = t20Components.GetEnumerator();
            var t21Components = archetype.GetComponents<T21>();
            var t21ComponentsEnumerator = t21Components.GetEnumerator();
            var t22Components = archetype.GetComponents<T22>();
            var t22ComponentsEnumerator = t22Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext() && t20ComponentsEnumerator.MoveNext() && t21ComponentsEnumerator.MoveNext() && t22ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current, ref t20ComponentsEnumerator.Current, ref t21ComponentsEnumerator.Current, ref t22ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            var t20Components = archetype.GetComponents<T20>();
            var t20ComponentsEnumerator = t20Components.GetEnumerator();
            var t21Components = archetype.GetComponents<T21>();
            var t21ComponentsEnumerator = t21Components.GetEnumerator();
            var t22Components = archetype.GetComponents<T22>();
            var t22ComponentsEnumerator = t22Components.GetEnumerator();
            var t23Components = archetype.GetComponents<T23>();
            var t23ComponentsEnumerator = t23Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext() && t20ComponentsEnumerator.MoveNext() && t21ComponentsEnumerator.MoveNext() && t22ComponentsEnumerator.MoveNext() && t23ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current, ref t20ComponentsEnumerator.Current, ref t21ComponentsEnumerator.Current, ref t22ComponentsEnumerator.Current, ref t23ComponentsEnumerator.Current);
            }
        }
    }



     public void InlineEntityQuery<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription description, ref T iForEach) where T : struct, IForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
        var query = Query(in description);
        foreach (var archetype in query.GetArchetypeIterator())
        {
            var entities = archetype.Entities;
            var entitiesEnumerator = entities.GetEnumerator();
            var t0Components = archetype.GetComponents<T0>();
            var t0ComponentsEnumerator = t0Components.GetEnumerator();
            var t1Components = archetype.GetComponents<T1>();
            var t1ComponentsEnumerator = t1Components.GetEnumerator();
            var t2Components = archetype.GetComponents<T2>();
            var t2ComponentsEnumerator = t2Components.GetEnumerator();
            var t3Components = archetype.GetComponents<T3>();
            var t3ComponentsEnumerator = t3Components.GetEnumerator();
            var t4Components = archetype.GetComponents<T4>();
            var t4ComponentsEnumerator = t4Components.GetEnumerator();
            var t5Components = archetype.GetComponents<T5>();
            var t5ComponentsEnumerator = t5Components.GetEnumerator();
            var t6Components = archetype.GetComponents<T6>();
            var t6ComponentsEnumerator = t6Components.GetEnumerator();
            var t7Components = archetype.GetComponents<T7>();
            var t7ComponentsEnumerator = t7Components.GetEnumerator();
            var t8Components = archetype.GetComponents<T8>();
            var t8ComponentsEnumerator = t8Components.GetEnumerator();
            var t9Components = archetype.GetComponents<T9>();
            var t9ComponentsEnumerator = t9Components.GetEnumerator();
            var t10Components = archetype.GetComponents<T10>();
            var t10ComponentsEnumerator = t10Components.GetEnumerator();
            var t11Components = archetype.GetComponents<T11>();
            var t11ComponentsEnumerator = t11Components.GetEnumerator();
            var t12Components = archetype.GetComponents<T12>();
            var t12ComponentsEnumerator = t12Components.GetEnumerator();
            var t13Components = archetype.GetComponents<T13>();
            var t13ComponentsEnumerator = t13Components.GetEnumerator();
            var t14Components = archetype.GetComponents<T14>();
            var t14ComponentsEnumerator = t14Components.GetEnumerator();
            var t15Components = archetype.GetComponents<T15>();
            var t15ComponentsEnumerator = t15Components.GetEnumerator();
            var t16Components = archetype.GetComponents<T16>();
            var t16ComponentsEnumerator = t16Components.GetEnumerator();
            var t17Components = archetype.GetComponents<T17>();
            var t17ComponentsEnumerator = t17Components.GetEnumerator();
            var t18Components = archetype.GetComponents<T18>();
            var t18ComponentsEnumerator = t18Components.GetEnumerator();
            var t19Components = archetype.GetComponents<T19>();
            var t19ComponentsEnumerator = t19Components.GetEnumerator();
            var t20Components = archetype.GetComponents<T20>();
            var t20ComponentsEnumerator = t20Components.GetEnumerator();
            var t21Components = archetype.GetComponents<T21>();
            var t21ComponentsEnumerator = t21Components.GetEnumerator();
            var t22Components = archetype.GetComponents<T22>();
            var t22ComponentsEnumerator = t22Components.GetEnumerator();
            var t23Components = archetype.GetComponents<T23>();
            var t23ComponentsEnumerator = t23Components.GetEnumerator();
            var t24Components = archetype.GetComponents<T24>();
            var t24ComponentsEnumerator = t24Components.GetEnumerator();
            while (entitiesEnumerator.MoveNext() && t0ComponentsEnumerator.MoveNext() && t1ComponentsEnumerator.MoveNext() && t2ComponentsEnumerator.MoveNext() && t3ComponentsEnumerator.MoveNext() && t4ComponentsEnumerator.MoveNext() && t5ComponentsEnumerator.MoveNext() && t6ComponentsEnumerator.MoveNext() && t7ComponentsEnumerator.MoveNext() && t8ComponentsEnumerator.MoveNext() && t9ComponentsEnumerator.MoveNext() && t10ComponentsEnumerator.MoveNext() && t11ComponentsEnumerator.MoveNext() && t12ComponentsEnumerator.MoveNext() && t13ComponentsEnumerator.MoveNext() && t14ComponentsEnumerator.MoveNext() && t15ComponentsEnumerator.MoveNext() && t16ComponentsEnumerator.MoveNext() && t17ComponentsEnumerator.MoveNext() && t18ComponentsEnumerator.MoveNext() && t19ComponentsEnumerator.MoveNext() && t20ComponentsEnumerator.MoveNext() && t21ComponentsEnumerator.MoveNext() && t22ComponentsEnumerator.MoveNext() && t23ComponentsEnumerator.MoveNext() && t24ComponentsEnumerator.MoveNext())
            {
                iForEach.Update(entitiesEnumerator.Current, ref t0ComponentsEnumerator.Current, ref t1ComponentsEnumerator.Current, ref t2ComponentsEnumerator.Current, ref t3ComponentsEnumerator.Current, ref t4ComponentsEnumerator.Current, ref t5ComponentsEnumerator.Current, ref t6ComponentsEnumerator.Current, ref t7ComponentsEnumerator.Current, ref t8ComponentsEnumerator.Current, ref t9ComponentsEnumerator.Current, ref t10ComponentsEnumerator.Current, ref t11ComponentsEnumerator.Current, ref t12ComponentsEnumerator.Current, ref t13ComponentsEnumerator.Current, ref t14ComponentsEnumerator.Current, ref t15ComponentsEnumerator.Current, ref t16ComponentsEnumerator.Current, ref t17ComponentsEnumerator.Current, ref t18ComponentsEnumerator.Current, ref t19ComponentsEnumerator.Current, ref t20ComponentsEnumerator.Current, ref t21ComponentsEnumerator.Current, ref t22ComponentsEnumerator.Current, ref t23ComponentsEnumerator.Current, ref t24ComponentsEnumerator.Current);
            }
        }
    }


}
