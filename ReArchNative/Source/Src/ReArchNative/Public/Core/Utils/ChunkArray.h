#pragma once

#include "ReArchDefine.h"


extern "C"
{
    struct Slot
    {
        int32 IndexOfChunk;
        int32 IndexInChunk;
    };

    struct Chunk
    {
        int32 ItemSize;
        int32 ItemCount;
        void* Data;
    };

    struct ChunkArray
    {
        int32 ItemSize;
        int32 ChunkCount;
        int32 ItemCount;

        Chunk* Chunks;
    };

    REARCHNATIVEMODULE_API ChunkArray* ChunkArray_Create(int32 chunkSize, int32 capcity);
    REARCHNATIVEMODULE_API void ChunkArray_Destroy(ChunkArray* arr);
    REARCHNATIVEMODULE_API int32 ChunkArray_GetItemCount(ChunkArray* arr);
    REARCHNATIVEMODULE_API int32 ChunkArray_GetItemSize(ChunkArray* arr);
    REARCHNATIVEMODULE_API int32 ChunkArray_Add(ChunkArray* arr, void* item);
    REARCHNATIVEMODULE_API void* ChunkArray_Get(ChunkArray* arr, int32 index);
    REARCHNATIVEMODULE_API void ChunkArray_Remove(ChunkArray* arr, int32 index);
}
