#pragma once
#include <Core/Component.h>

#include "ReArchDefine.h"


extern "C"
{
    struct NativeArray
    {
        uint8* data;
        int32 size;
        int32 itemSize;
    };

    NativeArray* NativeArray_Create(int32 itemSize, int32 itemCount);

    void NativeArray_Destroy(NativeArray* array);

    void NativeArray_Clear(NativeArray* array);

    void NativeArray_Set(NativeArray* array, int32 index, void* value);

}

