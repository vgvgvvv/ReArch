

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Arch.Core.Extensions.Internal;

namespace ReArch.Core;

public struct ComponentType
{

	public readonly int Id;

	public readonly int ByteSize;
	
	public ComponentType(int id, int byteSize)
	{
		Id = id;
		ByteSize = byteSize;
	}


	public Type Type => ComponentRegistry.Types[Id]!;
	
	public static implicit operator ComponentType(Type value)
	{
		return Component.GetComponentType(value);
	}
	
	public static implicit operator Type(ComponentType value)
	{
		return value.Type;
	}

}

public static class ComponentRegistry
{

	public static readonly Dictionary<Type, ComponentType> _typeToComponentType = new Dictionary<Type, ComponentType>();

	public static Type?[] _types = new Type[64];
	
	public static IReadOnlyDictionary<Type, ComponentType> TypeToComponentType => _typeToComponentType;

	public static IReadOnlyList<Type?> Types => _types;
	
	public static int Size { get; private set; }

	private static ComponentType Add(Type type, int typeSize)
	{
		if (TryGet(type, out var meta))
		{
			return meta;
		}

		// Register and assign component id
		var id = Size + 1;
		meta = new ComponentType(id, typeSize);
		_typeToComponentType.Add(type, meta);
		_types = _types.Add(id, type);

		Size++;
		return meta;
	}

	private static ComponentType Add(Type type, ComponentType componentType)
	{
		// Register and assign component id
		_typeToComponentType.TryAdd(type, componentType);
		_types = _types.Add(componentType.Id, type);

		Size++;
		return componentType;
	}

	public static ComponentType Add<T>()
	{
		return Add(typeof(T), SizeOf<T>());
	}


	public static ComponentType Add(Type type)
	{
		return Add(type, SizeOf(type));
	}

	public static bool Has<T>()
	{
		return Has(typeof(T));
	}

	public static bool Has(Type type)
	{
		return TypeToComponentType.ContainsKey(type);
	}

	public static bool Remove<T>()
	{
		var componentType = Component<T>.ComponentType;
		_types[componentType.Id] = null;
		return _typeToComponentType.Remove(componentType.Type);
	}

	public static bool Remove(Type type)
	{
		ComponentType componentType = type;
		_types[componentType.Id] = null;
		return _typeToComponentType.Remove(type);
	}

	public static bool Remove(Type type, out ComponentType compType)
	{
		var removed = _typeToComponentType.Remove(type, out compType);
		_types[compType.Id] = null;
		return removed;
	}

	public static void Replace(Type oldType, Type newType, int newTypeSize)
	{
		var id = Remove(oldType, out var oldComponentType) ? oldComponentType.Id : ++Size;

		_typeToComponentType.Add(newType, new ComponentType(id, newTypeSize));
		_types = _types.Add(id, newType);
	}

	public static void Replace<T0, T1>()
	{
		Replace(typeof(T0), typeof(T1), SizeOf<T1>());
	}

	public static void Replace(Type oldType, Type newType)
	{
		Replace(oldType, newType, SizeOf(newType));
	}

	public static bool TryGet<T>(out ComponentType componentType)
	{
		return TryGet(typeof(T), out componentType);
	}

	public static bool TryGet(Type type, out ComponentType componentType)
	{
		return TypeToComponentType.TryGetValue(type, out componentType);
	}

	private static int SizeOf<T>()
	{
		return typeof(T).IsValueType ? Unsafe.SizeOf<T>() : IntPtr.Size;
	}

	private static int SizeOf(Type type)
	{
		if (type.IsValueType)
		{
			return (int)typeof(Unsafe)
				.GetMethod(nameof(Unsafe.SizeOf))!
				.MakeGenericMethod(type)
				.Invoke(null, null)!;
		}

		return IntPtr.Size;
	}
	
}

public static class Component
{

	internal static int Id;

	public static ComponentType GetComponentType(Type type)
	{
		return !ComponentRegistry.TryGet(type, out var index) ? ComponentRegistry.Add(type) : index;
	}

	public static int GetHashCode(Span<ComponentType> obj)
	{
		
	}

	public static int GetHashCode(Span<uint> span)
	{
		
	}
	
}

public static class Component<T>
{

	
	public static readonly ComponentType ComponentType;

	public static readonly Signature Signature;
	
}