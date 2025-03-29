#pragma once
#include "ReArchDefine.h"



extern "C"
{
    struct BitSet
    {
        int32 HighestBit;
        int32 Max;
        uint32* Bits = nullptr;
    };

    BitSet* BitSet_Create(int32 highestBit);
}

