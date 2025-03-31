

using ReArch.Core;
using System;
using System.Threading;

namespace ReArch.Core.Utils;


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1>
        where T0 : unmanaged
        where T1 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7>
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
{
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType, Component<T20>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType, Component<T20>.ComponentType, Component<T21>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType, Component<T20>.ComponentType, Component<T21>.ComponentType, Component<T22>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType, Component<T20>.ComponentType, Component<T21>.ComponentType, Component<T22>.ComponentType, Component<T23>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}


/// <inheritdoc cref="Component"/>
public static class Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
    internal static readonly int Id;

    /// <summary>
    ///     An <see cref="Signature"/> for this given set of components.
    /// </summary>
    public static readonly Signature Signature;

    /// <summary>
    ///     The hash code for this given set of components.
    /// </summary>
    public static readonly int Hash;

    static Component()
    {
        Id = Interlocked.Increment(ref Component.Id);
        Signature = new Signature(new [] { Component<T0>.ComponentType, Component<T1>.ComponentType, Component<T2>.ComponentType, Component<T3>.ComponentType, Component<T4>.ComponentType, Component<T5>.ComponentType, Component<T6>.ComponentType, Component<T7>.ComponentType, Component<T8>.ComponentType, Component<T9>.ComponentType, Component<T10>.ComponentType, Component<T11>.ComponentType, Component<T12>.ComponentType, Component<T13>.ComponentType, Component<T14>.ComponentType, Component<T15>.ComponentType, Component<T16>.ComponentType, Component<T17>.ComponentType, Component<T18>.ComponentType, Component<T19>.ComponentType, Component<T20>.ComponentType, Component<T21>.ComponentType, Component<T22>.ComponentType, Component<T23>.ComponentType, Component<T24>.ComponentType });
        Hash = Signature.GetHashCode();
    }
}



