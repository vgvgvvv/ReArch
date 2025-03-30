using System;

using ReArch.Core;
using ReArch.Core.Utils;

namespace Arch.Core.Extensions.Internal;

internal static class BitSetExtensions
{

	internal static void SetBits(this BitSet bitSet, Slice<ComponentType> types)
    {
        foreach (var type in types)
        {
            var id = type.Id;
            bitSet.SetBit(id);
        }
    }

}
