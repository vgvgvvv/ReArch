#include "Core/Utils/ChunkArray.h"
#include "Alloc.h"
#include <string.h>

/**
 * 创建一个新的ChunkArray
 * @param chunkCount 每个块中可容纳的元素数量
 * @param itemSize 每个元素的大小（字节）
 * @param capacity 初始预分配的块数量
 * @return 新创建的ChunkArray指针
 */
ChunkArray* ChunkArray_Create(int32 chunkCount, int32 itemSize, int32 capacity)
{
    if (chunkCount <= 0 || capacity <= 0)
    {
        return nullptr;
    }
    
    // 创建ChunkArray结构
    ChunkArray* arr = NEW(ChunkArray);
    arr->ItemSizeInByte = itemSize; // 设置元素大小
    arr->ChunkCount = capacity;
    arr->ItemCount = 0;
    arr->ChunkSizeInBytes = chunkCount * itemSize;
    
    // 分配Chunks数组
    arr->Chunks = NEW_ARRAY(Chunk, capacity);
    
    // 初始化所有Chunk
    for (int32 i = 0; i < capacity; ++i)
    {
        arr->Chunks[i].ItemSize = arr->ItemSizeInByte;
        arr->Chunks[i].ItemCount = 0;
        arr->Chunks[i].Data = NEW_ARRAY(uint8, arr->ChunkSizeInBytes);
    }
    
    return arr;
}

/**
 * 销毁ChunkArray并释放相关内存
 * @param arr 要销毁的ChunkArray指针
 */
void ChunkArray_Destroy(ChunkArray* arr)
{
    if (!arr)
    {
        return;
    }
    
    // 释放每个Chunk的数据内存
    for (int32 i = 0; i < arr->ChunkCount; ++i)
    {
        if (arr->Chunks[i].Data)
        {
            DELETE_ARRAY(arr->Chunks[i].Data);
            arr->Chunks[i].Data = nullptr;
        }
    }
    
    // 释放Chunks数组
    if (arr->Chunks)
    {
        DELETE_ARRAY(arr->Chunks);
        arr->Chunks = nullptr;
    }
    
    // 释放ChunkArray结构本身
    DELETE(arr);
}

/**
 * 获取ChunkArray中的元素总数
 * @param arr ChunkArray指针
 * @return 元素总数
 */
int32 ChunkArray_GetItemCount(ChunkArray* arr)
{
    if (!arr)
    {
        return 0;
    }
    
    return arr->ItemCount;
}

/**
 * 获取ChunkArray中元素的大小
 * @param arr ChunkArray指针
 * @return 元素大小（字节）
 */
int32 ChunkArray_GetItemSize(ChunkArray* arr)
{
    if (!arr)
    {
        return 0;
    }
    
    return arr->ItemSizeInByte;
}

/**
 * 将元素转换为槽位（块索引和块内索引）
 * @param arr ChunkArray指针
 * @param index 元素的线性索引
 * @return 表示元素位置的Slot结构
 */
static Slot IndexToSlot(ChunkArray* arr, int32 index)
{
    Slot slot;
    
    if (!arr || index < 0 || index >= arr->ItemCount)
    {
        slot.IndexOfChunk = -1;
        slot.IndexInChunk = -1;
        return slot;
    }
    
    // 计算每个块中的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    
    if (itemsPerChunk <= 0)
    {
        slot.IndexOfChunk = -1;
        slot.IndexInChunk = -1;
        return slot;
    }
    
    // 计算块索引和块内索引
    slot.IndexOfChunk = index / itemsPerChunk;
    slot.IndexInChunk = index % itemsPerChunk;
    
    return slot;
}

/**
 * 确保ChunkArray有足够的容量存储新元素
 * @param arr ChunkArray指针
 * @return 成功返回true，失败返回false
 */
static bool EnsureCapacity(ChunkArray* arr)
{
    if (!arr)
    {
        return false;
    }
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    
    // 计算当前正在使用的块索引
    int32 currentChunkIndex = (arr->ItemCount > 0) ? (arr->ItemCount - 1) / itemsPerChunk : 0;
    
    // 检查当前块是否已满
    bool needNewChunk = false;
    if (currentChunkIndex < arr->ChunkCount)
    {
        Chunk* currentChunk = &arr->Chunks[currentChunkIndex];
        needNewChunk = (currentChunk->ItemCount >= itemsPerChunk);
    }
    else
    {
        // 超出了块数组范围，需要新块
        needNewChunk = true;
    }
    
    if (needNewChunk)
    {
        // 需要创建新块，扩展Chunks数组
        int32 newChunkCount = arr->ChunkCount + 1;
        Chunk* newChunks = NEW_ARRAY(Chunk, newChunkCount);
        
        // 复制现有块
        if (arr->Chunks)
        {
            memcpy(newChunks, arr->Chunks, arr->ChunkCount * sizeof(Chunk));
        }
        
        // 初始化新块
        newChunks[arr->ChunkCount].ItemSize = arr->ItemSizeInByte;
        newChunks[arr->ChunkCount].ItemCount = 0;
        newChunks[arr->ChunkCount].Data = NEW_ARRAY(uint8, arr->ChunkSizeInBytes);
        
        // 释放旧的Chunks数组并更新
        if (arr->Chunks)
        {
            DELETE_ARRAY(arr->Chunks);
        }
        
        arr->Chunks = newChunks;
        arr->ChunkCount = newChunkCount;
    }
    
    return true;
}

/**
 * 添加元素到ChunkArray
 * @param arr ChunkArray指针
 * @param item 指向要添加元素的指针
 * @return 添加元素的索引，失败返回-1
 */
int32 ChunkArray_Add(ChunkArray* arr, void* item)
{
    if (!arr || !item)
    {
        return -1;
    }
    
    // 确保有足够的空间
    if (!EnsureCapacity(arr))
    {
        return -1;
    }
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    
    // 查找可用的块
    int32 targetChunkIndex = arr->ItemCount / itemsPerChunk;
    RE_ASSERT(targetChunkIndex < arr->ChunkCount)

    // 获取目标块
    Chunk* targetChunk = &arr->Chunks[targetChunkIndex];
    
    // 计算新元素在块中的位置
    int32 indexInChunk = targetChunk->ItemCount;
    uint8* targetAddress = static_cast<uint8*>(targetChunk->Data) + (indexInChunk * targetChunk->ItemSize);
    
    // 复制元素数据
    memcpy(targetAddress, item, targetChunk->ItemSize);
    
    // 更新计数
    targetChunk->ItemCount++;
    arr->ItemCount++;
    
    // 计算并返回新元素的全局索引
    int32 globalIndex = 0;
    for (int32 i = 0; i < targetChunkIndex; ++i)
    {
        globalIndex += arr->Chunks[i].ItemCount;
    }
    globalIndex += indexInChunk;
    
    return globalIndex;
}

/**
 * 获取ChunkArray中指定索引处的元素
 * @param arr ChunkArray指针
 * @param index 元素索引
 * @return 指向元素的指针，失败返回nullptr
 */
void* ChunkArray_Get(ChunkArray* arr, int32 index)
{
    if (!arr || index < 0 || index >= arr->ItemCount)
    {
        return nullptr;
    }
    
    // 转换为槽位
    Slot slot = IndexToSlot(arr, index);
    
    if (slot.IndexOfChunk < 0 || slot.IndexOfChunk >= arr->ChunkCount ||
        slot.IndexInChunk < 0 || !arr->Chunks[slot.IndexOfChunk].Data)
    {
        return nullptr;
    }
    
    // 计算元素地址并返回
    uint8* itemAddress = static_cast<uint8*>(arr->Chunks[slot.IndexOfChunk].Data) + 
                         (slot.IndexInChunk * arr->Chunks[slot.IndexOfChunk].ItemSize);
    
    return itemAddress;
}

/**
 * 从ChunkArray中移除指定索引处的元素
 * @param arr ChunkArray指针
 * @param index 要移除元素的索引
 */
void ChunkArray_Remove(ChunkArray* arr, int32 index)
{
    if (!arr || index < 0 || index >= arr->ItemCount)
    {
        return;
    }
    
    // 转换为槽位
    Slot slot = IndexToSlot(arr, index);
    
    if (slot.IndexOfChunk < 0 || slot.IndexOfChunk >= arr->ChunkCount ||
        slot.IndexInChunk < 0 || !arr->Chunks[slot.IndexOfChunk].Data)
    {
        return;
    }
    
    Chunk* chunk = &arr->Chunks[slot.IndexOfChunk];
    
    // 计算要移除元素的地址
    uint8* removeAddr = static_cast<uint8*>(chunk->Data) + (slot.IndexInChunk * chunk->ItemSize);
    
    // 如果不是最后一个元素，移动后面的元素填补空缺
    if (slot.IndexInChunk < chunk->ItemCount - 1)
    {
        uint8* nextAddr = removeAddr + chunk->ItemSize;
        int32 bytesToMove = (chunk->ItemCount - slot.IndexInChunk - 1) * chunk->ItemSize;
        memmove(removeAddr, nextAddr, bytesToMove);
    }
    
    // 更新计数
    chunk->ItemCount--;
    arr->ItemCount--;
}