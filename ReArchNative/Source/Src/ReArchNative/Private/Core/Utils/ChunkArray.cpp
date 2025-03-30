#include "Core/Utils/ChunkArray.h"
#include "Alloc.h"
#include <string.h>

/**
 * 创建一个新的ChunkArray
 * @param countInChunk 每个块中可容纳的元素数量
 * @param itemSize 每个元素的大小（字节）
 * @param capacity 初始预分配的块数量
 * @return 新创建的ChunkArray指针
 */
ChunkArray* ChunkArray_Create(int32 countInChunk, int32 itemSize, int32 capacity)
{
    if (countInChunk <= 0 || capacity <= 0)
    {
        return nullptr;
    }
    
    // 创建ChunkArray结构
    ChunkArray* arr = NEW(ChunkArray);
    arr->ItemSizeInByte = itemSize; // 设置元素大小
    arr->ChunkCount = capacity;
    arr->ItemCount = 0;
    arr->ChunkSizeInBytes = countInChunk * itemSize;
    
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

int32 ChunkArray_AddDefault(ChunkArray* arr)
{
    if (!arr)
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
    memset(targetAddress, 0, targetChunk->ItemSize);

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
 * 批量添加多个连续元素到ChunkArray
 * @param arr ChunkArray指针
 * @param items 指向要添加的元素数组的指针
 * @param count 要添加的元素数量
 * @return 第一个添加元素的索引，失败返回-1
 */
int32 ChunkArray_AddRange(ChunkArray* arr, void* items, int32 count)
{
    if (!arr || !items || count <= 0)
    {
        return -1;
    }
    
    // 记录当前元素数量作为返回值（第一个添加元素的索引）
    int32 firstIndex = arr->ItemCount;
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    
    // 确保有足够的空间存储所有新元素
    int32 requiredCapacity = arr->ItemCount + count;
    ChunkArray_EnsureCapacity(arr, requiredCapacity);
    
    // 逐个添加元素
    uint8* sourcePtr = static_cast<uint8*>(items);
    for (int32 i = 0; i < count; ++i)
    {
        // 计算当前元素的目标块索引
        int32 targetChunkIndex = arr->ItemCount / itemsPerChunk;
        
        // 确保不会越界
        if (targetChunkIndex >= arr->ChunkCount)
        {
            // 这不应该发生，因为我们已经确保了容量，但为了健壮性添加此检查
            return firstIndex;
        }
        
        // 获取目标块
        Chunk* targetChunk = &arr->Chunks[targetChunkIndex];
        
        // 计算新元素在块中的位置
        int32 indexInChunk = targetChunk->ItemCount;
        uint8* targetAddress = static_cast<uint8*>(targetChunk->Data) + (indexInChunk * targetChunk->ItemSize);
        
        // 复制元素数据
        memcpy(targetAddress, sourcePtr, targetChunk->ItemSize);
        
        // 更新指针位置到下一个源元素
        sourcePtr += targetChunk->ItemSize;
        
        // 更新计数
        targetChunk->ItemCount++;
        arr->ItemCount++;
    }
    
    return firstIndex;
}

int32 ChunkArray_AddDefaultRange(ChunkArray* arr, int32 count)
{
    if (!arr || count <= 0)
    {
        return -1;
    }
    
    // 记录当前元素数量作为返回值（第一个添加元素的索引）
    int32 firstIndex = arr->ItemCount;
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    
    // 确保有足够的空间存储所有新元素
    int32 requiredCapacity = arr->ItemCount + count;
    ChunkArray_EnsureCapacity(arr, requiredCapacity);
    
    // 逐个添加默认元素
    for (int32 i = 0; i < count; ++i)
    {
        // 计算当前元素的目标块索引
        int32 targetChunkIndex = arr->ItemCount / itemsPerChunk;
        
        // 确保不会越界
        if (targetChunkIndex >= arr->ChunkCount)
        {
            // 这不应该发生，因为我们已经确保了容量，但为了健壮性添加此检查
            return firstIndex;
        }
        
        // 获取目标块
        Chunk* targetChunk = &arr->Chunks[targetChunkIndex];
        
        // 计算新元素在块中的位置
        int32 indexInChunk = targetChunk->ItemCount;
        uint8* targetAddress = static_cast<uint8*>(targetChunk->Data) + (indexInChunk * targetChunk->ItemSize);
        
        // 将内存置零以创建默认元素
        memset(targetAddress, 0, targetChunk->ItemSize);
        
        // 更新计数
        targetChunk->ItemCount++;
        arr->ItemCount++;
    }
    
    return firstIndex;
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

void ChunkArray_RemoveRange(ChunkArray* arr, int32 index, int32 count)
{
    if (!arr || index < 0 || count <= 0 || index + count > arr->ItemCount)
    {
        return;
    }

    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    if (itemsPerChunk <= 0)
    {
        return;
    }

    // 获取起始和结束位置的槽位
    Slot startSlot = IndexToSlot(arr, index);
    Slot endSlot = IndexToSlot(arr, index + count - 1);

    if (startSlot.IndexOfChunk < 0 || endSlot.IndexOfChunk >= arr->ChunkCount)
    {
        return;
    }

    // 如果要删除的范围在同一个块内
    if (startSlot.IndexOfChunk == endSlot.IndexOfChunk)
    {
        Chunk* chunk = &arr->Chunks[startSlot.IndexOfChunk];
        uint8* removeAddr = static_cast<uint8*>(chunk->Data) + (startSlot.IndexInChunk * chunk->ItemSize);
        
        // 移动后面的元素填补空缺
        if (endSlot.IndexInChunk < chunk->ItemCount - 1)
        {
            uint8* nextAddr = static_cast<uint8*>(chunk->Data) + ((endSlot.IndexInChunk + 1) * chunk->ItemSize);
            int32 bytesToMove = (chunk->ItemCount - endSlot.IndexInChunk - 1) * chunk->ItemSize;
            memmove(removeAddr, nextAddr, bytesToMove);
        }
        
        chunk->ItemCount -= count;
    }
    else
    {
        // 处理第一个块
        Chunk* firstChunk = &arr->Chunks[startSlot.IndexOfChunk];
        firstChunk->ItemCount = startSlot.IndexInChunk;

        // 处理中间的块
        for (int32 i = startSlot.IndexOfChunk + 1; i < endSlot.IndexOfChunk; ++i)
        {
            arr->Chunks[i].ItemCount = 0;
        }

        // 处理最后一个块
        Chunk* lastChunk = &arr->Chunks[endSlot.IndexOfChunk];
        int32 remainingItems = lastChunk->ItemCount - endSlot.IndexInChunk - 1;
        if (remainingItems > 0)
        {
            uint8* moveFrom = static_cast<uint8*>(lastChunk->Data) + ((endSlot.IndexInChunk + 1) * lastChunk->ItemSize);
            uint8* moveTo = static_cast<uint8*>(firstChunk->Data) + (startSlot.IndexInChunk * firstChunk->ItemSize);
            memcpy(moveTo, moveFrom, remainingItems * lastChunk->ItemSize);
            firstChunk->ItemCount += remainingItems;
        }
        lastChunk->ItemCount = 0;
    }

    arr->ItemCount -= count;
}

/**
 * 设置ChunkArray指定索引处的元素值
 * @param arr ChunkArray指针
 * @param index 要设置的元素索引
 * @param item 指向新值的指针
 */
void ChunkArray_Set(ChunkArray* arr, int32 index, void* item)
{
    if (!arr || !item || index < 0 || index >= arr->ItemCount)
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
    
    // 计算目标地址
    uint8* targetAddress = static_cast<uint8*>(arr->Chunks[slot.IndexOfChunk].Data) + 
                          (slot.IndexInChunk * arr->Chunks[slot.IndexOfChunk].ItemSize);
    
    // 复制元素数据
    memcpy(targetAddress, item, arr->ItemSizeInByte);
}

/**
 * 设置ChunkArray中连续多个元素为相同的值
 * @param arr ChunkArray指针
 * @param index 起始索引
 * @param count 要设置的元素数量
 * @param item 指向要设置的值的指针
 */
void ChunkArray_SetRange(ChunkArray* arr, int32 index, int32 count, void* item)
{
    if (!arr || !item || index < 0 || count <= 0 || index + count > arr->ItemCount)
    {
        return;
    }
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    if (itemsPerChunk <= 0)
    {
        return;
    }
    
    // 逐个设置元素
    for (int32 i = 0; i < count; ++i)
    {
        int32 currentIndex = index + i;
        
        // 计算槽位
        int32 chunkIndex = currentIndex / itemsPerChunk;
        int32 indexInChunk = currentIndex % itemsPerChunk;
        
        if (chunkIndex >= arr->ChunkCount)
        {
            // 越界检查
            break;
        }
        
        Chunk* chunk = &arr->Chunks[chunkIndex];
        if (!chunk->Data || indexInChunk >= chunk->ItemCount)
        {
            // 无效的块或块内索引
            continue;
        }
        
        // 计算目标地址
        uint8* targetAddress = static_cast<uint8*>(chunk->Data) + (indexInChunk * chunk->ItemSize);
        
        // 复制元素数据
        memcpy(targetAddress, item, chunk->ItemSize);
    }
}

void ChunkArray_EnsureCapacity(ChunkArray* arr, int32 count)
{
    if (!arr || count <= 0)
    {
        return;
    }
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    if (itemsPerChunk <= 0)
    {
        return;
    }
    
    // 计算需要的块数量
    int32 requiredChunks = (count + itemsPerChunk - 1) / itemsPerChunk; // 向上取整
    
    // 如果已有足够的块，直接返回
    if (requiredChunks <= arr->ChunkCount)
    {
        return;
    }
    
    // 创建新的Chunks数组
    Chunk* newChunks = NEW_ARRAY(Chunk, requiredChunks);
    
    // 复制现有块
    if (arr->Chunks)
    {
        memcpy(newChunks, arr->Chunks, arr->ChunkCount * sizeof(Chunk));
    }
    
    // 初始化新增的块
    for (int32 i = arr->ChunkCount; i < requiredChunks; ++i)
    {
        newChunks[i].ItemSize = arr->ItemSizeInByte;
        newChunks[i].ItemCount = 0;
        newChunks[i].Data = NEW_ARRAY(uint8, arr->ChunkSizeInBytes);
    }
    
    // 释放旧的Chunks数组
    if (arr->Chunks)
    {
        DELETE_ARRAY(arr->Chunks);
    }
    
    // 更新ChunkArray
    arr->Chunks = newChunks;
    arr->ChunkCount = requiredChunks;
}

void ChunkArray_TrimExcess(ChunkArray* arr)
{
    if (!arr || arr->ChunkCount <= 0)
    {
        return;
    }
    
    // 计算每个块可容纳的元素数量
    int32 itemsPerChunk = arr->ChunkSizeInBytes / arr->ItemSizeInByte;
    if (itemsPerChunk <= 0)
    {
        return;
    }
    
    // 计算实际需要的块数量（向上取整）
    int32 usedChunks = (arr->ItemCount + itemsPerChunk - 1) / itemsPerChunk;
    if (usedChunks <= 0)
    {
        usedChunks = 1; // 至少保留一个块
    }
    
    // 如果没有多余的块，直接返回
    if (usedChunks >= arr->ChunkCount)
    {
        return;
    }
    
    // 创建新的Chunks数组
    Chunk* newChunks = NEW_ARRAY(Chunk, usedChunks);
    
    // 复制使用中的块
    memcpy(newChunks, arr->Chunks, usedChunks * sizeof(Chunk));
    
    // 释放多余块的数据内存
    for (int32 i = usedChunks; i < arr->ChunkCount; ++i)
    {
        if (arr->Chunks[i].Data)
        {
            DELETE_ARRAY(arr->Chunks[i].Data);
        }
    }
    
    // 释放旧的Chunks数组
    DELETE_ARRAY(arr->Chunks);
    
    // 更新ChunkArray
    arr->Chunks = newChunks;
    arr->ChunkCount = usedChunks;
}

void ChunkArray_Clear(ChunkArray* arr)
{
    if (!arr)
    {
        return;
    }
    
    // 重置所有块的元素计数
    for (int32 i = 0; i < arr->ChunkCount; ++i)
    {
        arr->Chunks[i].ItemCount = 0;
    }
    
    // 重置总元素计数
    arr->ItemCount = 0;
}

/**
 * 从一个ChunkArray复制元素到另一个ChunkArray
 * @param from 源ChunkArray指针
 * @param fromIndex 源数组中的起始索引
 * @param to 目标ChunkArray指针
 * @param toIndex 目标数组中的起始索引
 * @param count 要复制的元素数量
 */
void ChunkArray_Copy(ChunkArray* from, int32 fromIndex, ChunkArray* to, int32 toIndex, int32 count)
{
    // 参数检查
    if (!from || !to || fromIndex < 0 || toIndex < 0 || count <= 0)
    {
        return;
    }

    // 检查元素大小是否匹配
    if (from->ItemSizeInByte != to->ItemSizeInByte)
    {
        return;
    }

    // 检查索引范围
    if (fromIndex + count > from->ItemCount || toIndex + count > to->ItemCount)
    {
        return;
    }

    // 计算每个块可容纳的元素数量
    int32 itemsPerChunkFrom = from->ChunkSizeInBytes / from->ItemSizeInByte;
    int32 itemsPerChunkTo = to->ChunkSizeInBytes / to->ItemSizeInByte;

    // 逐个元素复制
    for (int32 i = 0; i < count; ++i)
    {
        // 计算源元素位置
        int32 fromChunkIndex = (fromIndex + i) / itemsPerChunkFrom;
        int32 fromItemIndex = (fromIndex + i) % itemsPerChunkFrom;
        uint8* sourcePtr = static_cast<uint8*>(from->Chunks[fromChunkIndex].Data) + 
                          (fromItemIndex * from->ItemSizeInByte);

        // 计算目标元素位置
        int32 toChunkIndex = (toIndex + i) / itemsPerChunkTo;
        int32 toItemIndex = (toIndex + i) % itemsPerChunkTo;
        uint8* targetPtr = static_cast<uint8*>(to->Chunks[toChunkIndex].Data) + 
                          (toItemIndex * to->ItemSizeInByte);

        // 复制数据
        memcpy(targetPtr, sourcePtr, from->ItemSizeInByte);
    }
}