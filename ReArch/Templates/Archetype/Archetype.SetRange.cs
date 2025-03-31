

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class Archetype
{


    internal void SetRange<T0, T1>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T20>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t20Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T20>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t20Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T21>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t21Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T20>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t20Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T21>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t21Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T22>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t22Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default,in T23 t23Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T20>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t20Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T21>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t21Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T22>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t22Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T23>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t23Component;
            } while (enumerator.MoveNext());
        }
    }


    internal void SetRange<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in int fromIndex, in int toIndex,  in T0 t0Component = default,in T1 t1Component = default,in T2 t2Component = default,in T3 t3Component = default,in T4 t4Component = default,in T5 t5Component = default,in T6 t6Component = default,in T7 t7Component = default,in T8 t8Component = default,in T9 t9Component = default,in T10 t10Component = default,in T11 t11Component = default,in T12 t12Component = default,in T13 t13Component = default,in T14 t14Component = default,in T15 t15Component = default,in T16 t16Component = default,in T17 t17Component = default,in T18 t18Component = default,in T19 t19Component = default,in T20 t20Component = default,in T21 t21Component = default,in T22 t22Component = default,in T23 t23Component = default,in T24 t24Component = default)
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
        {
            var enumerator = GetComponents<T0>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t0Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T1>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t1Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T2>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t2Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T3>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t3Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T4>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t4Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T5>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t5Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T6>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t6Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T7>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t7Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T8>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t8Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T9>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t9Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T10>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t10Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T11>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t11Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T12>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t12Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T13>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t13Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T14>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t14Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T15>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t15Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T16>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t16Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T17>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t17Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T18>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t18Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T19>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t19Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T20>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t20Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T21>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t21Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T22>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t22Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T23>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t23Component;
            } while (enumerator.MoveNext());
        }
        {
            var enumerator = GetComponents<T24>().GetEnumerator(fromIndex, toIndex - fromIndex);
            do
            {
                enumerator.Current = t24Component;
            } while (enumerator.MoveNext());
        }
    }



}