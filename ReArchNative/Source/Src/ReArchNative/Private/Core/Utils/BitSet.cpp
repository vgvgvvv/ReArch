#include "Core/Utils/BitSet.h"
#include "Alloc.h"
#include "ReArchPrivateDefine.h"

const int BitSize = (sizeof(uint32) * 8) - 1;           // 31
const int IndexSize = 5;                              // log_2(BitSize + 1)

BitSet* BitSet_Create(int32 highestBit)
{
    BitSet* bitset = NEW(BitSet);
    
    // 计算需要多少个uint32来存储位
    int32 numInts = (highestBit + BitSize) / BitSize;
    bitset->HighestBit = highestBit;
    bitset->Bits = NEW_ARRAY(uint32, numInts);
    
    // 初始化所有位为0
    memset(bitset->Bits, 0, numInts * sizeof(uint32));
    
    return bitset;
}

BitSet* BitSet_FromPtr(uint32* bits, int32 uintSize, int32 highestBit)
{
    BitSet* bitset = NEW(BitSet);

    bitset->HighestBit = highestBit;
    bitset->Bits = bits;

    // 初始化所有位为0
    memset(bitset->Bits, 0, uintSize * sizeof(uint32));

    return bitset;
}

void BitSet_Destroy(BitSet* bitset)
{
    if (bitset)
    {
        DELETE_ARRAY(bitset->Bits);
        DELETE(bitset);
    }
}

uint32* BitSet_GetBitPtr(BitSet* bitset)
{
    if(bitset)
    {
        return bitset->Bits;
    }
    return nullptr;
}

int32 BitSet_GetHighestBit(BitSet *bitset)
{
    if (bitset)
    {
        return bitset->HighestBit;
    }
    return 0;
}


bool BitSet_IsSet(BitSet* bitset, int32 index)
{
    if (!bitset || !bitset->Bits || index < 0 || index > bitset->HighestBit)
    {
        return false;
    }
    
    int32 arrayIndex = index / BitSize;
    int32 bitIndex = index % BitSize;
    
    return (bitset->Bits[arrayIndex] & (1 << bitIndex)) != 0;
}

bool BitSet_SetBit(BitSet* bitset, int32 index)
{
    if (!bitset || !bitset->Bits || index < 0 || index > bitset->HighestBit)
    {
        return false;
    }
    
    int32 arrayIndex = index / BitSize;
    int32 bitIndex = index % BitSize;
    
    bitset->Bits[arrayIndex] |= (1 << bitIndex);
    return true;
}

bool BitSet_ClearBit(BitSet* bitset, int32 index)
{
    if (!bitset || !bitset->Bits || index < 0 || index > bitset->HighestBit)
    {
        return false;
    }
    
    int32 arrayIndex = index / BitSize;
    int32 bitIndex = index % BitSize;
    
    bitset->Bits[arrayIndex] &= ~(1 << bitIndex);
    return true;
}

void BitSet_SetAll(BitSet* bitset)
{
    if (!bitset || !bitset->Bits)
    {
        return;
    }
    
    int32 numInts = (bitset->HighestBit + BitSize) / BitSize;
    for (int32 i = 0; i < numInts; ++i)
    {
        bitset->Bits[i] = 0xFFFFFFFF; // 设置所有位为1
    }
}

void BitSet_ClearAll(BitSet* bitset)
{
    if (!bitset || !bitset->Bits)
    {
        return;
    }
    
    int32 numInts = (bitset->HighestBit + BitSize) / BitSize;
    memset(bitset->Bits, 0, numInts * sizeof(uint32));
}

bool BitSet_All(BitSet* bitset, BitSet* otherBitset)
{
    if (!bitset || !otherBitset || !bitset->Bits || !otherBitset->Bits)
    {
        return false;
    }
    
    // 确保两个BitSet至少有一个公共部分
    int32 minHighestBit = (bitset->HighestBit < otherBitset->HighestBit) ? 
                           bitset->HighestBit : otherBitset->HighestBit;
    
    int32 numInts = (minHighestBit + BitSize) / BitSize;
    
    // 检查bitset是否包含otherBitset的所有位
    for (int32 i = 0; i < numInts; ++i)
    {
        // 如果otherBitset中有1的位在bitset中是0，则返回false
        if ((bitset->Bits[i] & otherBitset->Bits[i]) != otherBitset->Bits[i])
        {
            return false;
        }
    }
    
    return true;
}

bool BitSet_Any(BitSet* bitset, BitSet* otherBitset)
{
    if (!bitset || !otherBitset || !bitset->Bits || !otherBitset->Bits)
    {
        return false;
    }
    
    // 确保两个BitSet至少有一个公共部分
    int32 minHighestBit = (bitset->HighestBit < otherBitset->HighestBit) ? 
                           bitset->HighestBit : otherBitset->HighestBit;
    
    int32 numInts = (minHighestBit + BitSize) / BitSize;
    
    // 检查是否有任何一位同时在bitset和otherBitset中为1
    for (int32 i = 0; i < numInts; ++i)
    {
        if ((bitset->Bits[i] & otherBitset->Bits[i]) != 0)
        {
            return true;
        }
    }
    
    return false;
}

bool BitSet_None(BitSet* bitset, BitSet* otherBitset)
{
    if (!bitset || !otherBitset || !bitset->Bits || !otherBitset->Bits)
    {
        return true; // 如果任一为空，则认为没有重叠位
    }
    
    // 确保两个BitSet至少有一个公共部分
    int32 minHighestBit = (bitset->HighestBit < otherBitset->HighestBit) ? 
                           bitset->HighestBit : otherBitset->HighestBit;
    
    int32 numInts = (minHighestBit + BitSize) / BitSize;
    
    // 检查是否没有任何一位同时在bitset和otherBitset中为1
    for (int32 i = 0; i < numInts; ++i)
    {
        if ((bitset->Bits[i] & otherBitset->Bits[i]) != 0)
        {
            return false;
        }
    }
    
    return true;
}

bool BitSet_Exclusive(BitSet* bitset, BitSet* otherBitset)
{
    if (!bitset || !otherBitset || !bitset->Bits || !otherBitset->Bits)
    {
        return false;
    }
    
    // 确保两个BitSet至少有一个公共部分
    int32 minHighestBit = (bitset->HighestBit < otherBitset->HighestBit) ? 
                           bitset->HighestBit : otherBitset->HighestBit;
    
    int32 numInts = (minHighestBit + BitSize) / BitSize;
    
    // 检查是否存在互斥的位（一个为1，另一个为0）
    for (int32 i = 0; i < numInts; ++i)
    {
        uint32 exclusive = bitset->Bits[i] ^ otherBitset->Bits[i];
        if (exclusive != 0)
        {
            return true;
        }
    }
    
    return false;
}