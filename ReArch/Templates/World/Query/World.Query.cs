

// TODO: Move query with T0 into world.cs?

namespace ReArch.Core;
public partial class World
{


    public void Query<T0>(in QueryDescription queryDescription, ForEach<T0> forEntity)
        where T0 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
			while(t0Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1>(in QueryDescription queryDescription, ForEach<T0, T1> forEntity)
        where T0 : unmanaged
        where T1 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2>(in QueryDescription queryDescription, ForEach<T0, T1, T2> forEntity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3> forEntity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4> forEntity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
    		var t20Enumerator = archetype.GetComponents<T20>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
    		var t20Enumerator = archetype.GetComponents<T20>().GetEnumerator();
    		var t21Enumerator = archetype.GetComponents<T21>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
    		var t20Enumerator = archetype.GetComponents<T20>().GetEnumerator();
    		var t21Enumerator = archetype.GetComponents<T21>().GetEnumerator();
    		var t22Enumerator = archetype.GetComponents<T22>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
    		var t20Enumerator = archetype.GetComponents<T20>().GetEnumerator();
    		var t21Enumerator = archetype.GetComponents<T21>().GetEnumerator();
    		var t22Enumerator = archetype.GetComponents<T22>().GetEnumerator();
    		var t23Enumerator = archetype.GetComponents<T23>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext() && t23Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current, ref t23Enumerator.Current);
			}
		}
	}


    public void Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription queryDescription, ForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> forEntity)
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
    		var t0Enumerator = archetype.GetComponents<T0>().GetEnumerator();
    		var t1Enumerator = archetype.GetComponents<T1>().GetEnumerator();
    		var t2Enumerator = archetype.GetComponents<T2>().GetEnumerator();
    		var t3Enumerator = archetype.GetComponents<T3>().GetEnumerator();
    		var t4Enumerator = archetype.GetComponents<T4>().GetEnumerator();
    		var t5Enumerator = archetype.GetComponents<T5>().GetEnumerator();
    		var t6Enumerator = archetype.GetComponents<T6>().GetEnumerator();
    		var t7Enumerator = archetype.GetComponents<T7>().GetEnumerator();
    		var t8Enumerator = archetype.GetComponents<T8>().GetEnumerator();
    		var t9Enumerator = archetype.GetComponents<T9>().GetEnumerator();
    		var t10Enumerator = archetype.GetComponents<T10>().GetEnumerator();
    		var t11Enumerator = archetype.GetComponents<T11>().GetEnumerator();
    		var t12Enumerator = archetype.GetComponents<T12>().GetEnumerator();
    		var t13Enumerator = archetype.GetComponents<T13>().GetEnumerator();
    		var t14Enumerator = archetype.GetComponents<T14>().GetEnumerator();
    		var t15Enumerator = archetype.GetComponents<T15>().GetEnumerator();
    		var t16Enumerator = archetype.GetComponents<T16>().GetEnumerator();
    		var t17Enumerator = archetype.GetComponents<T17>().GetEnumerator();
    		var t18Enumerator = archetype.GetComponents<T18>().GetEnumerator();
    		var t19Enumerator = archetype.GetComponents<T19>().GetEnumerator();
    		var t20Enumerator = archetype.GetComponents<T20>().GetEnumerator();
    		var t21Enumerator = archetype.GetComponents<T21>().GetEnumerator();
    		var t22Enumerator = archetype.GetComponents<T22>().GetEnumerator();
    		var t23Enumerator = archetype.GetComponents<T23>().GetEnumerator();
    		var t24Enumerator = archetype.GetComponents<T24>().GetEnumerator();
			while(t0Enumerator.MoveNext() && t1Enumerator.MoveNext() && t2Enumerator.MoveNext() && t3Enumerator.MoveNext() && t4Enumerator.MoveNext() && t5Enumerator.MoveNext() && t6Enumerator.MoveNext() && t7Enumerator.MoveNext() && t8Enumerator.MoveNext() && t9Enumerator.MoveNext() && t10Enumerator.MoveNext() && t11Enumerator.MoveNext() && t12Enumerator.MoveNext() && t13Enumerator.MoveNext() && t14Enumerator.MoveNext() && t15Enumerator.MoveNext() && t16Enumerator.MoveNext() && t17Enumerator.MoveNext() && t18Enumerator.MoveNext() && t19Enumerator.MoveNext() && t20Enumerator.MoveNext() && t21Enumerator.MoveNext() && t22Enumerator.MoveNext() && t23Enumerator.MoveNext() && t24Enumerator.MoveNext())
			{
				forEntity(ref t0Enumerator.Current, ref t1Enumerator.Current, ref t2Enumerator.Current, ref t3Enumerator.Current, ref t4Enumerator.Current, ref t5Enumerator.Current, ref t6Enumerator.Current, ref t7Enumerator.Current, ref t8Enumerator.Current, ref t9Enumerator.Current, ref t10Enumerator.Current, ref t11Enumerator.Current, ref t12Enumerator.Current, ref t13Enumerator.Current, ref t14Enumerator.Current, ref t15Enumerator.Current, ref t16Enumerator.Current, ref t17Enumerator.Current, ref t18Enumerator.Current, ref t19Enumerator.Current, ref t20Enumerator.Current, ref t21Enumerator.Current, ref t22Enumerator.Current, ref t23Enumerator.Current, ref t24Enumerator.Current);
			}
		}
	}
}
