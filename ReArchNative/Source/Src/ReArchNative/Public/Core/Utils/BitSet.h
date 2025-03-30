#pragma once
#include "ReArchDefine.h"



extern "C"
{
    struct BitSet
    {
        int32 HighestBit = 0;
        uint32* Bits = nullptr;
    };

    REARCHNATIVEMODULE_API BitSet* BitSet_Create(int32 highestBit);
    REARCHNATIVEMODULE_API BitSet* BitSet_FromPtr(uint32* bits, int32 uintSize, int32 highestBit);
    REARCHNATIVEMODULE_API void BitSet_Destroy(BitSet* bitset);
    REARCHNATIVEMODULE_API uint32* BitSet_GetBitPtr(BitSet* bitset);
    REARCHNATIVEMODULE_API int32 BitSet_GetHighestBit(BitSet* bitset);
    REARCHNATIVEMODULE_API int32 BitSet_GetMax(BitSet* bitset);
    REARCHNATIVEMODULE_API bool BitSet_IsSet(BitSet* bitset, int32 index);
    REARCHNATIVEMODULE_API bool BitSet_SetBit(BitSet* bitset, int32 index);
    REARCHNATIVEMODULE_API bool BitSet_ClearBit(BitSet* bitset, int32 index);
    REARCHNATIVEMODULE_API void BitSet_SetAll(BitSet* bitset);
    REARCHNATIVEMODULE_API void BitSet_ClearAll(BitSet* bitset);
    REARCHNATIVEMODULE_API bool BitSet_All(BitSet* bitset, BitSet* otherBitset);
    REARCHNATIVEMODULE_API bool BitSet_Any(BitSet* bitset, BitSet* otherBitset);
    REARCHNATIVEMODULE_API bool BitSet_None(BitSet* bitset, BitSet* otherBitset);
    REARCHNATIVEMODULE_API bool BitSet_Exclusive(BitSet* bitset, BitSet* otherBitset);

}

