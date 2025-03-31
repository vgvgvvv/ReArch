

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{
    
    public void Set<T0, T1>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default)
        where T0 : unmanaged
        where T1 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default,in T20 t20ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T20>())
			{
				component = t20ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default,in T20 t20ComponentValue = default,in T21 t21ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T20>())
			{
				component = t20ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T21>())
			{
				component = t21ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default,in T20 t20ComponentValue = default,in T21 t21ComponentValue = default,in T22 t22ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T20>())
			{
				component = t20ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T21>())
			{
				component = t21ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T22>())
			{
				component = t22ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default,in T20 t20ComponentValue = default,in T21 t21ComponentValue = default,in T22 t22ComponentValue = default,in T23 t23ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T20>())
			{
				component = t20ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T21>())
			{
				component = t21ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T22>())
			{
				component = t22ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T23>())
			{
				component = t23ComponentValue;
			}
        }

	}

   
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription queryDescription, in T0 t0ComponentValue = default,in T1 t1ComponentValue = default,in T2 t2ComponentValue = default,in T3 t3ComponentValue = default,in T4 t4ComponentValue = default,in T5 t5ComponentValue = default,in T6 t6ComponentValue = default,in T7 t7ComponentValue = default,in T8 t8ComponentValue = default,in T9 t9ComponentValue = default,in T10 t10ComponentValue = default,in T11 t11ComponentValue = default,in T12 t12ComponentValue = default,in T13 t13ComponentValue = default,in T14 t14ComponentValue = default,in T15 t15ComponentValue = default,in T16 t16ComponentValue = default,in T17 t17ComponentValue = default,in T18 t18ComponentValue = default,in T19 t19ComponentValue = default,in T20 t20ComponentValue = default,in T21 t21ComponentValue = default,in T22 t22ComponentValue = default,in T23 t23ComponentValue = default,in T24 t24ComponentValue = default)
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
			foreach (ref var component in archetype.GetComponents<T0>())
			{
				component = t0ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T1>())
			{
				component = t1ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T2>())
			{
				component = t2ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T3>())
			{
				component = t3ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T4>())
			{
				component = t4ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T5>())
			{
				component = t5ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T6>())
			{
				component = t6ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T7>())
			{
				component = t7ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T8>())
			{
				component = t8ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T9>())
			{
				component = t9ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T10>())
			{
				component = t10ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T11>())
			{
				component = t11ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T12>())
			{
				component = t12ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T13>())
			{
				component = t13ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T14>())
			{
				component = t14ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T15>())
			{
				component = t15ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T16>())
			{
				component = t16ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T17>())
			{
				component = t17ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T18>())
			{
				component = t18ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T19>())
			{
				component = t19ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T20>())
			{
				component = t20ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T21>())
			{
				component = t21ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T22>())
			{
				component = t22ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T23>())
			{
				component = t23ComponentValue;
			}
			foreach (ref var component in archetype.GetComponents<T24>())
			{
				component = t24ComponentValue;
			}
        }

	}

   
    }

