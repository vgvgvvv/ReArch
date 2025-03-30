using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

using Arch.Core.Extensions.Internal;

using Collections.Pooled;

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

    public Signature(Slice<ComponentType> components)
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


    public Slice<ComponentType> Components => new Slice<ComponentType>(ComponentsArray);

    public int Count => ComponentsArray.Length; 
    
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
    
    public static Signature Add(Signature first, Signature second)
    {
        // Copy signatures into new array
        using var set = new PooledSet<ComponentType>(first.Count + second.Count);
        set.UnionWith(first.ComponentsArray);
        set.UnionWith(second.ComponentsArray);

        var result = new Signature(set.ToArray());
        return result;
    }
    
    public static Signature Remove(Signature first, Signature second)
    {
        // Copy signatures into new array
        using var set = new PooledSet<ComponentType>(first.Count + second.Count);
        set.UnionWith(first.ComponentsArray);
        set.ExceptWith(second.ComponentsArray);

        var result = new Signature(set.ToArray());
        return result;
    }
    
    public static bool operator ==(Signature left, Signature right)
    {
        return left.Equals(right);
    }
    
    public static bool operator !=(Signature left, Signature right)
    {
        return !left.Equals(right);
    }

    public static Signature operator +(Signature a, Signature b)
    {
        return Add(a, b);
    }

    public static Signature operator -(Signature a, Signature b)
    {
        return Remove(a, b);
    }
    
    public static implicit operator Signature(ComponentType component)
    {
        return new Signature(component);
    }
    
    public static implicit operator Signature(Slice<ComponentType> components)
    {
        return new Signature(components);
    }
    
    public static implicit operator ComponentType[](Signature signature)
    {
        return signature.ComponentsArray;
    }
    
    public static implicit operator Slice<ComponentType>(Signature signature)
    {
        return signature.Components;
    }

    public BitSet ToBitSet()
    {
        int max = ComponentsArray.Max(x => x.Id);
        var bitSet = new BitSet(max);
        bitSet.SetBits(Components);
        return bitSet;
    }
}

[SkipLocalsInit]
public partial struct QueryDescription : IEquatable<QueryDescription>
{
    public static readonly QueryDescription Null = new();
    private int _hashCode;

  
    public Signature All { get; private set; } = Signature.Null;
    public Signature Any { get; private set; } = Signature.Null;
    public Signature None { get; private set; } = Signature.Null;
    public Signature Exclusive { get; private set; } = Signature.Null;
    
    public QueryDescription()
    {
        _hashCode = -1;
    }
    
    public QueryDescription(Signature? all = null, Signature? any = null, Signature? none = null, Signature? exclusive = null)
    {
        All = all ?? All;
        Any = any ?? Any;
        None = none ?? None;
        Exclusive = exclusive ?? Exclusive;

        _hashCode = -1;
        _hashCode = GetHashCode();
    }
    
    public void Build()
    {
        _hashCode = -1;
        _hashCode = GetHashCode();
    }
    
    [UnscopedRef]
    public ref QueryDescription WithAll<T>()
    {
        All = Component<T>.Signature;
        Build();
        return ref this;
    }
    
    [UnscopedRef]

    public ref QueryDescription WithAny<T>()
    {
        Any = Component<T>.Signature;
        Build();
        return ref this;
    }
    
    [UnscopedRef]

    public ref QueryDescription WithNone<T>()
    {
        None = Component<T>.Signature;
        Build();
        return ref this;
    }
    
    [UnscopedRef]

    public ref QueryDescription WithExclusive<T>()
    {
        Exclusive = Component<T>.Signature;
        Build();
        return ref this;
    }
    
    public bool Equals(QueryDescription other)
    {
        return GetHashCode() == other.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj is QueryDescription other && Equals(other);
    }

    public override int GetHashCode()
    {
        // Cache hashcode since the calculation is expensive.
        var hash = _hashCode;
        if (hash != -1)
        {
            return hash;
        }

        unchecked
        {
            // Overflow is fine, just wrap{
            hash = 17;
            hash = (hash * 23) + All.GetHashCode();
            hash = (hash * 23) + Any.GetHashCode();
            hash = (hash * 23) + None.GetHashCode();
            hash = (hash * 23) + Exclusive.GetHashCode();
            _hashCode = hash;
            return hash;
        }
    }
    
    public static bool operator ==(QueryDescription left, QueryDescription right)
    {
        return left.Equals(right);
    }
    
    public static bool operator !=(QueryDescription left, QueryDescription right)
    {
        return !left.Equals(right);
    }
}

//TODO: DoQuery
// public partial class Query : IEquatable<Query>