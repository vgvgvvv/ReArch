
using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public  partial class Archetype
{

    internal Components<T0, T1> Get<T0, T1>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        return new Components<T0, T1>(ref component0, ref component1);
    }

    internal Components<T0, T1, T2> Get<T0, T1, T2>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        return new Components<T0, T1, T2>(ref component0, ref component1, ref component2);
    }

    internal Components<T0, T1, T2, T3> Get<T0, T1, T2, T3>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        return new Components<T0, T1, T2, T3>(ref component0, ref component1, ref component2, ref component3);
    }

    internal Components<T0, T1, T2, T3, T4> Get<T0, T1, T2, T3, T4>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        return new Components<T0, T1, T2, T3, T4>(ref component0, ref component1, ref component2, ref component3, ref component4);
    }

    internal Components<T0, T1, T2, T3, T4, T5> Get<T0, T1, T2, T3, T4, T5>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        return new Components<T0, T1, T2, T3, T4, T5>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6> Get<T0, T1, T2, T3, T4, T5, T6>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7> Get<T0, T1, T2, T3, T4, T5, T6, T7>(scoped ref int index)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        ref var component20 = ref GetComponents<T20>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19, ref component20);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        ref var component20 = ref GetComponents<T20>()[index];
        ref var component21 = ref GetComponents<T21>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19, ref component20, ref component21);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        ref var component20 = ref GetComponents<T20>()[index];
        ref var component21 = ref GetComponents<T21>()[index];
        ref var component22 = ref GetComponents<T22>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19, ref component20, ref component21, ref component22);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        ref var component20 = ref GetComponents<T20>()[index];
        ref var component21 = ref GetComponents<T21>()[index];
        ref var component22 = ref GetComponents<T22>()[index];
        ref var component23 = ref GetComponents<T23>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19, ref component20, ref component21, ref component22, ref component23);
    }

    internal Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> Get<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(scoped ref int index)
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
        ref var component0 = ref GetComponents<T0>()[index];
        ref var component1 = ref GetComponents<T1>()[index];
        ref var component2 = ref GetComponents<T2>()[index];
        ref var component3 = ref GetComponents<T3>()[index];
        ref var component4 = ref GetComponents<T4>()[index];
        ref var component5 = ref GetComponents<T5>()[index];
        ref var component6 = ref GetComponents<T6>()[index];
        ref var component7 = ref GetComponents<T7>()[index];
        ref var component8 = ref GetComponents<T8>()[index];
        ref var component9 = ref GetComponents<T9>()[index];
        ref var component10 = ref GetComponents<T10>()[index];
        ref var component11 = ref GetComponents<T11>()[index];
        ref var component12 = ref GetComponents<T12>()[index];
        ref var component13 = ref GetComponents<T13>()[index];
        ref var component14 = ref GetComponents<T14>()[index];
        ref var component15 = ref GetComponents<T15>()[index];
        ref var component16 = ref GetComponents<T16>()[index];
        ref var component17 = ref GetComponents<T17>()[index];
        ref var component18 = ref GetComponents<T18>()[index];
        ref var component19 = ref GetComponents<T19>()[index];
        ref var component20 = ref GetComponents<T20>()[index];
        ref var component21 = ref GetComponents<T21>()[index];
        ref var component22 = ref GetComponents<T22>()[index];
        ref var component23 = ref GetComponents<T23>()[index];
        ref var component24 = ref GetComponents<T24>()[index];
        return new Components<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(ref component0, ref component1, ref component2, ref component3, ref component4, ref component5, ref component6, ref component7, ref component8, ref component9, ref component10, ref component11, ref component12, ref component13, ref component14, ref component15, ref component16, ref component17, ref component18, ref component19, ref component20, ref component21, ref component22, ref component23, ref component24);
    }


}