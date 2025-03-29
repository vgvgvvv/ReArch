#pragma once
#include <Core/Component.h>

#include "ReArchDefine.h"


extern "C"
{
    struct NativeArray
    {
        int32 size;
        int32 itemSize;
        uint8* data;
    };

    REARCHNATIVEMODULE_API NativeArray* NativeArray_Create(int32 itemSize, int32 itemCount);

    REARCHNATIVEMODULE_API void NativeArray_Destroy(NativeArray* array);

    REARCHNATIVEMODULE_API void NativeArray_Clear(NativeArray* array);

    REARCHNATIVEMODULE_API void NativeArray_Set(NativeArray* array, int32 index, void* value);

    REARCHNATIVEMODULE_API void* NativeArray_Get(NativeArray* array, int32 index);

    REARCHNATIVEMODULE_API int32 NativeArray_GetSize(NativeArray* array);

    REARCHNATIVEMODULE_API int32 NativeArray_GetItemSize(NativeArray* array);
}

