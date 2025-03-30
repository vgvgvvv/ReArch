using System;
using System.Runtime.CompilerServices;

using ReArch.Core.Utils;

namespace ReArch.Core;

public struct Signature : IEquatable<Signature>
{
    public static readonly Signature Null = new();

    private int _hashCode;

    public Signature()
    {
        ComponentsArray = [];
        _hashCode = -1;
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


    public Slice<ComponentType> Components
    {
        get => new Slice<ComponentType>(ComponentsArray);
    }
    
    public bool Equals(Signature other)
    {
        return GetHashCode() == other.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        return obj is Signature other && Equals(other);
    }

    public override int GetHashCode()
    {
// Cache hashcode since the calculation is expensive.
        var hash = _hashCode;  // Local copy for improved speed by reducing property access.
        if (hash != -1)
        {
            return hash;
        }

        unchecked
        {
            hash = Component.GetHashCode(Components);
            _hashCode = hash;
            return hash;
        }
    }

}