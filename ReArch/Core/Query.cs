using System;
using System.Diagnostics;
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
        if (Components.Length == 0)
        {
            return BitSet.Default;
        }
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

public partial class Query : IEquatable<Query>
{
    private readonly Archetypes _allArchetypes;
    private readonly PooledList<Archetype> _matchingArchetypes;
    private int _allArchetypesHashCode;
    
    private readonly QueryDescription _queryDescription;
    private readonly BitSet _any;
    private readonly BitSet _all;
    private readonly BitSet _none;
    private readonly BitSet _exclusive;

    private readonly bool _isExclusive;
    
    internal Query(Archetypes allArchetypes, QueryDescription description)
    {
        _allArchetypes = allArchetypes;
        _matchingArchetypes = new PooledList<Archetype>();
        _allArchetypesHashCode = -1;

        Debug.Assert(
            !((description.Any.Count != 0 ||
                    description.All.Count != 0 ||
                    description.None.Count != 0) &&
                description.Exclusive.Count != 0),
            "If Any, All or None have items then Exclusive may not have any items"
        );

        // Convert to `BitSet`s.
        _all = description.All.ToBitSet();
        _any = description.Any.ToBitSet();
        _none = description.None.ToBitSet();
        _exclusive = description.Exclusive.ToBitSet();

        // Handle exclusive.
        if (description.Exclusive.Count != 0)
        {
            _isExclusive = true;
        }

        _queryDescription = description;
    }
    
    public bool Matches(BitSet bitset)
    {
        return _isExclusive ? _exclusive.Exclusive(bitset) : _all.All(bitset) && _any.Any(bitset) && _none.None(bitset);
    }
    
    // TODO: Implement these methods
    // public QueryArchetypeIterator GetArchetypeIterator()
    // public QueryChunkIterator GetChunkIterator()
    // public QueryChunkEnumerator GetEnumerator()
    
    private void Match()
    {
        // Hashcode changed, list was modified?
        var newArchetypesHashCode = _allArchetypes.GetHashCode();
        if (_allArchetypesHashCode == newArchetypesHashCode)
        {
            return;
        }

        // Check all archetypes and update list
        var allArchetypes = _allArchetypes.Items;
        _matchingArchetypes.Clear();
        foreach (var archetype in allArchetypes)
        {
            var matches = Matches(archetype.BitSet);
            if (matches)
            {
                _matchingArchetypes.Add(archetype);
            }
        }

        _allArchetypesHashCode = newArchetypesHashCode;
    }
    
    public bool Equals(Query other)
    {
        return Equals(_any, other._any) && Equals(_all, other._all) && Equals(_none, other._none) && Equals(_exclusive, other._exclusive) && _queryDescription.Equals(other._queryDescription);
    }
    
    public override bool Equals(object? obj)
    {
        return obj is Query other && Equals(other);
    }
    
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _any is not null ? _any.GetHashCode() : 0;
            hashCode = (hashCode * 397) ^ (_all is not null ? _all.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_none is not null ? _none.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_exclusive?.GetHashCode() ?? 0);
            hashCode = (hashCode * 397) ^ _queryDescription.GetHashCode();

            return hashCode;
        }
    }
    
    public static bool operator ==(Query left, Query right)
    {
        return left.Equals(right);
    }
    
    public static bool operator !=(Query left, Query right)
    {
        return !left.Equals(right);
    }
}