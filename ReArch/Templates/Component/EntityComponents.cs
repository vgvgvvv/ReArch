

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;


[SkipLocalsInit]
public ref struct EntityComponents<T0>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    public Ref<T20> t20;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component,ref T20 t20Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    t20 = new Ref<T20>(ref t20Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    public Ref<T20> t20;
    public Ref<T21> t21;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component,ref T20 t20Component,ref T21 t21Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    t20 = new Ref<T20>(ref t20Component);
    t21 = new Ref<T21>(ref t21Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    public Ref<T20> t20;
    public Ref<T21> t21;
    public Ref<T22> t22;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component,ref T20 t20Component,ref T21 t21Component,ref T22 t22Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    t20 = new Ref<T20>(ref t20Component);
    t21 = new Ref<T21>(ref t21Component);
    t22 = new Ref<T22>(ref t22Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    public Ref<T20> t20;
    public Ref<T21> t21;
    public Ref<T22> t22;
    public Ref<T23> t23;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component,ref T20 t20Component,ref T21 t21Component,ref T22 t22Component,ref T23 t23Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    t20 = new Ref<T20>(ref t20Component);
    t21 = new Ref<T21>(ref t21Component);
    t22 = new Ref<T22>(ref t22Component);
    t23 = new Ref<T23>(ref t23Component);
    
    }
}

[SkipLocalsInit]
public ref struct EntityComponents<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
{

    public ReadOnlyRef<Entity> Entity;
    public Ref<T0> t0;
    public Ref<T1> t1;
    public Ref<T2> t2;
    public Ref<T3> t3;
    public Ref<T4> t4;
    public Ref<T5> t5;
    public Ref<T6> t6;
    public Ref<T7> t7;
    public Ref<T8> t8;
    public Ref<T9> t9;
    public Ref<T10> t10;
    public Ref<T11> t11;
    public Ref<T12> t12;
    public Ref<T13> t13;
    public Ref<T14> t14;
    public Ref<T15> t15;
    public Ref<T16> t16;
    public Ref<T17> t17;
    public Ref<T18> t18;
    public Ref<T19> t19;
    public Ref<T20> t20;
    public Ref<T21> t21;
    public Ref<T22> t22;
    public Ref<T23> t23;
    public Ref<T24> t24;
    

    [SkipLocalsInit]
    public EntityComponents(ref Entity entity, ref T0 t0Component,ref T1 t1Component,ref T2 t2Component,ref T3 t3Component,ref T4 t4Component,ref T5 t5Component,ref T6 t6Component,ref T7 t7Component,ref T8 t8Component,ref T9 t9Component,ref T10 t10Component,ref T11 t11Component,ref T12 t12Component,ref T13 t13Component,ref T14 t14Component,ref T15 t15Component,ref T16 t16Component,ref T17 t17Component,ref T18 t18Component,ref T19 t19Component,ref T20 t20Component,ref T21 t21Component,ref T22 t22Component,ref T23 t23Component,ref T24 t24Component)
    {
        Entity = new ReadOnlyRef<Entity>(in entity);
        t0 = new Ref<T0>(ref t0Component);
    t1 = new Ref<T1>(ref t1Component);
    t2 = new Ref<T2>(ref t2Component);
    t3 = new Ref<T3>(ref t3Component);
    t4 = new Ref<T4>(ref t4Component);
    t5 = new Ref<T5>(ref t5Component);
    t6 = new Ref<T6>(ref t6Component);
    t7 = new Ref<T7>(ref t7Component);
    t8 = new Ref<T8>(ref t8Component);
    t9 = new Ref<T9>(ref t9Component);
    t10 = new Ref<T10>(ref t10Component);
    t11 = new Ref<T11>(ref t11Component);
    t12 = new Ref<T12>(ref t12Component);
    t13 = new Ref<T13>(ref t13Component);
    t14 = new Ref<T14>(ref t14Component);
    t15 = new Ref<T15>(ref t15Component);
    t16 = new Ref<T16>(ref t16Component);
    t17 = new Ref<T17>(ref t17Component);
    t18 = new Ref<T18>(ref t18Component);
    t19 = new Ref<T19>(ref t19Component);
    t20 = new Ref<T20>(ref t20Component);
    t21 = new Ref<T21>(ref t21Component);
    t22 = new Ref<T22>(ref t22Component);
    t23 = new Ref<T23>(ref t23Component);
    t24 = new Ref<T24>(ref t24Component);
    
    }
}


