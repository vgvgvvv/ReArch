
using System;

namespace ReArch.Core;

public partial class World
{


        public void Query<T0>(in QueryDescription description, ForEachWithEntity<T0> forEach)
                where T0 : unmanaged
        {
            var query = Query(in description);
            foreach (var archetype in query.GetArchetypeIterator())
            {
                var entities = archetype.Entities;
                var entitiesEnumerator = entities.GetEnumerator();
                var t0Components = archetype.GetComponents<T0>();
                var t0Enumerator = t0Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1>(in QueryDescription description, ForEachWithEntity<T0, T1> forEach)
                where T0 : unmanaged
                where T1 : unmanaged
        {
            var query = Query(in description);
            foreach (var archetype in query.GetArchetypeIterator())
            {
                var entities = archetype.Entities;
                var entitiesEnumerator = entities.GetEnumerator();
                var t0Components = archetype.GetComponents<T0>();
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2>(in QueryDescription description, ForEachWithEntity<T0, T1, T2> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                var t20Components = archetype.GetComponents<T20>();
                var t20Enumerator = t20Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                var t20Components = archetype.GetComponents<T20>();
                var t20Enumerator = t20Components.GetEnumerator();
                var t21Components = archetype.GetComponents<T21>();
                var t21Enumerator = t21Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                var t20Components = archetype.GetComponents<T20>();
                var t20Enumerator = t20Components.GetEnumerator();
                var t21Components = archetype.GetComponents<T21>();
                var t21Enumerator = t21Components.GetEnumerator();
                var t22Components = archetype.GetComponents<T22>();
                var t22Enumerator = t22Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                var t20Components = archetype.GetComponents<T20>();
                var t20Enumerator = t20Components.GetEnumerator();
                var t21Components = archetype.GetComponents<T21>();
                var t21Enumerator = t21Components.GetEnumerator();
                var t22Components = archetype.GetComponents<T22>();
                var t22Enumerator = t22Components.GetEnumerator();
                var t23Components = archetype.GetComponents<T23>();
                var t23Enumerator = t23Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext() && t23Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current, ref t23Enumerator.Current);
                }
                
            }
        }
    

        public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription description, ForEachWithEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> forEach)
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
                var t0Enumerator = t0Components.GetEnumerator();
                var t1Components = archetype.GetComponents<T1>();
                var t1Enumerator = t1Components.GetEnumerator();
                var t2Components = archetype.GetComponents<T2>();
                var t2Enumerator = t2Components.GetEnumerator();
                var t3Components = archetype.GetComponents<T3>();
                var t3Enumerator = t3Components.GetEnumerator();
                var t4Components = archetype.GetComponents<T4>();
                var t4Enumerator = t4Components.GetEnumerator();
                var t5Components = archetype.GetComponents<T5>();
                var t5Enumerator = t5Components.GetEnumerator();
                var t6Components = archetype.GetComponents<T6>();
                var t6Enumerator = t6Components.GetEnumerator();
                var t7Components = archetype.GetComponents<T7>();
                var t7Enumerator = t7Components.GetEnumerator();
                var t8Components = archetype.GetComponents<T8>();
                var t8Enumerator = t8Components.GetEnumerator();
                var t9Components = archetype.GetComponents<T9>();
                var t9Enumerator = t9Components.GetEnumerator();
                var t10Components = archetype.GetComponents<T10>();
                var t10Enumerator = t10Components.GetEnumerator();
                var t11Components = archetype.GetComponents<T11>();
                var t11Enumerator = t11Components.GetEnumerator();
                var t12Components = archetype.GetComponents<T12>();
                var t12Enumerator = t12Components.GetEnumerator();
                var t13Components = archetype.GetComponents<T13>();
                var t13Enumerator = t13Components.GetEnumerator();
                var t14Components = archetype.GetComponents<T14>();
                var t14Enumerator = t14Components.GetEnumerator();
                var t15Components = archetype.GetComponents<T15>();
                var t15Enumerator = t15Components.GetEnumerator();
                var t16Components = archetype.GetComponents<T16>();
                var t16Enumerator = t16Components.GetEnumerator();
                var t17Components = archetype.GetComponents<T17>();
                var t17Enumerator = t17Components.GetEnumerator();
                var t18Components = archetype.GetComponents<T18>();
                var t18Enumerator = t18Components.GetEnumerator();
                var t19Components = archetype.GetComponents<T19>();
                var t19Enumerator = t19Components.GetEnumerator();
                var t20Components = archetype.GetComponents<T20>();
                var t20Enumerator = t20Components.GetEnumerator();
                var t21Components = archetype.GetComponents<T21>();
                var t21Enumerator = t21Components.GetEnumerator();
                var t22Components = archetype.GetComponents<T22>();
                var t22Enumerator = t22Components.GetEnumerator();
                var t23Components = archetype.GetComponents<T23>();
                var t23Enumerator = t23Components.GetEnumerator();
                var t24Components = archetype.GetComponents<T24>();
                var t24Enumerator = t24Components.GetEnumerator();
                while (entitiesEnumerator.MoveNext() && t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext() && t23Enumerator.MoveNext() && t24Enumerator.MoveNext())
                {
                    forEach(entitiesEnumerator.Current, ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current, ref t23Enumerator.Current, ref t24Enumerator.Current);
                }
                
            }
        }
    

}