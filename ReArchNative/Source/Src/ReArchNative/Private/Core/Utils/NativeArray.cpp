#include "Core/Utils/NativeArray.h"

#include <Alloc.h>

/**
 * 创建一个新的NativeArray
 * @param itemSize 每个元素的大小（字节）
 * @param itemCount 元素数量
 * @return 新创建的NativeArray指针
 */
NativeArray* NativeArray_Create(int32 itemSize, int32 itemCount)
{
    NativeArray* array = NEW(NativeArray);
    array->itemSize = itemSize;
    array->size = itemCount;
    array->data =  NEW_ARRAY(uint8, itemSize * itemCount);
    return array;
}

/**
 * 销毁NativeArray并释放内存
 * @param array 要销毁的NativeArray指针
 */
void NativeArray_Destroy(NativeArray* array)
{
    if (array)
    {
        if (array->data)
        {
            SAFE_DELETE_ARRAY(array->data);
            array->data = nullptr;
        }
        SAFE_DELETE(array)
    }
}

/**
 * 清空NativeArray中的所有数据（设置为0）
 * @param array 要清空的NativeArray指针
 */
void NativeArray_Clear(NativeArray* array)
{
    if (array && array->data)
    {
        memset(array->data, 0, array->itemSize * array->size);
    }
}

/**
 * 设置NativeArray中指定索引位置的值
 * @param array 目标NativeArray指针
 * @param index 要设置的元素索引
 * @param value 要设置的值
 */
void NativeArray_Set(NativeArray* array, int32 index, void* value)
{
    if (array && array->data && index >= 0 && index < array->size && value)
    {
        // 计算目标内存位置
        uint8* targetPosition = array->data + (index * array->itemSize);
        
        // 直接将数据从value复制到目标位置
        // 复制的大小由itemSize决定
        memcpy(targetPosition, value, array->itemSize);
    }
}

/**
 * 获取NativeArray中指定索引位置的值
 * @param array 源NativeArray指针
 * @param index 要获取的元素索引
 * @param result 用于存储结果的指针
 */
void* NativeArray_Get(NativeArray* array, int32 index)
{
    if (array && array->data && index >= 0 && index < array->size)
    {
        // 计算源内存位置
        uint8* sourcePosition = array->data + (index * array->itemSize);
        return sourcePosition;
    }
    return nullptr;
}

int32 NativeArray_GetSize(NativeArray *array)
{
    if(array == nullptr)
    {
        return 0;
    }
    return array->size;
}

int32 NativeArray_GetItemSize(NativeArray *array)
{
    if(array == nullptr)
    {
        return 0;
    }
    return array->itemSize;
}
