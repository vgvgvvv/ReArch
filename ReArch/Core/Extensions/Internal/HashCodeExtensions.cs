using System;
using System.Runtime.InteropServices;

using ReArch.Core.Utils;

namespace Arch.Core.Extensions.Internal;

internal static class HashCodeExtensions
{
	public unsafe static void AddBytes(ref this HashCode hashCode, byte* bytes, int length)
	{
		for (int i = 0; i < length; i++)
		{
			hashCode.Add(bytes[i]);
		}
	}

	public unsafe static void AddSlice<T>(ref this HashCode hashCode, Slice<T> items)
		where T : unmanaged
	{
		hashCode.AddBytes((byte*)items.FirstItem, items.ItemSize * items.Length);
	}

	
}
