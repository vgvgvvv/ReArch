#include "Core/Utils/Slice.h"
#include "Alloc.h"

/**
 * 从现有的Slice获取子Slice
 * @param slice 源Slice指针
 * @param sliceIndex 起始元素索引
 * @param count 要包含的元素数量
 * @return 新的Slice结构体
 */
Slice GetSubSlice(const Slice* slice, int sliceIndex, int count)
{
    Slice subSlice;
    
    // 参数验证
    if (!slice || !slice->firstItem || sliceIndex < 0 || count <= 0 || 
        sliceIndex >= slice->itemCount)
    {
        // 返回一个空的Slice
        subSlice.firstItem = nullptr;
        subSlice.itemCount = 0;
        subSlice.itemSize = 0;
        return subSlice;
    }
    
    // 确保不超出原始Slice的范围
    if (sliceIndex + count > slice->itemCount)
    {
        count = slice->itemCount - sliceIndex;
    }
    
    // 计算子Slice的第一个元素的地址
    char* basePtr = static_cast<char*>(slice->firstItem);
    void* subFirstItem = basePtr + (sliceIndex * slice->itemSize);
    
    // 创建子Slice
    subSlice.firstItem = subFirstItem;
    subSlice.itemCount = count;
    subSlice.itemSize = slice->itemSize;
    
    return subSlice;
}