using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Collections.Pooled;

namespace ReArch.Core;

public static class SignatureBuilder
{
    /// <summary>
    /// Creates a <see cref="Signature"/> from a <see cref="ReadOnlySpan{T}"/> e.g. a collection expression.
    /// </summary>
    /// <param name="components">The <see cref="ReadOnlySpan{T}"/>, e.g. the collection expression.</param>
    /// <returns>The created <see cref="Signature"/>.</returns>
    public static Signature Create(ReadOnlySpan<ComponentType> components)
    {
        return new Signature(components);
    }
}

[SkipLocalsInit]
[CollectionBuilder(typeof(SignatureBuilder), nameof(SignatureBuilder.Create))]
public struct Signature : IEquatable<Signature>
{
    public static readonly Signature Null = new();

    private int _hashCode;

    public Signature()
    {
        ComponentsArray = [];
        _hashCode = -1;
    }

    public Signature(ReadOnlySpan<ComponentType> components)
    {
        ComponentsArray = components.ToArray();
        _hashCode = -1;
        _hashCode = GetHashCode();
    }

    public Signature(params ComponentType[] components)
    {
        ComponentsArray = components;
        _hashCode = -1;
        _hashCode = GetHashCode();
    }

    /// <summary>
    ///     An array of <see cref="ComponentType"/>s.
    /// </summary>
    internal ComponentType[] ComponentsArray
    {
        get;
        set;
    } = [];

    
    
    public bool Equals(Signature other)
    {
        
    }

    public override bool Equals(object obj)
    {
        
    }

    public override int GetHashCode()
    {

    }

}