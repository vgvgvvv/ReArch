#pragma once
#include "ReArchDefine.h"

extern "C"
{
    struct Slice
    {
        void* firstItem;
        int itemCount;
        int itemSize;
    };

    REARCHNATIVEMODULE_API Slice GetSubSlice(const Slice* slice, int sliceIndex, int count);
};