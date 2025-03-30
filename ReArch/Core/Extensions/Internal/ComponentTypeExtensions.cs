using System;

using ReArch.Core;
using ReArch.Core.Utils;

namespace Arch.Core.Extensions.Internal;

public static class ComponentTypeExtensions
{

	internal static int ToByteSize(this Slice<ComponentType> types)
	{
		var size = 0;
		foreach (var type in types)
		{
			var typeSize = type.ByteSize;
			typeSize = typeSize != 1 ? typeSize : 0; // Ignore tag components
			size += typeSize;
		}

		return size;
	}

	internal static int[] ToLookupArray(this Slice<ComponentType> types)
	{
		// Get maximum component ID.
		var max = 0;
		foreach (var type in types)
		{
			var componentId = type.Id;
			if (componentId >= max)
			{
				max = componentId;
			}
		}

		// Create lookup table where the component ID points to the component index.
		var array = new int[max + 1];
		Array.Fill(array, -1);

		for (var index = 0; index < types.Length; index++)
		{
			ref var type = ref types[index];
			var componentId = type.Id;
			array[componentId] = index;
		}

		return array;
	}
	
}
