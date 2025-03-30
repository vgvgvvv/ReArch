using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

internal struct Slot
{
	int IndexOfChunk;
	int IndexInChunk;
};

internal unsafe struct Chunk
{
	int ItemSizeInByte;
	int ItemCount;
	void* Data;
};

internal unsafe struct ChunkArray_Native
{
	int ItemSizeInByte;
	int ItemCount;
	int ChunkCount;
	int ChunkSizeInBytes;

	Chunk* Chunks;
};

/// <summary>
/// 分块数组，提供对原生ChunkArray的C#包装，适用于大规模数据的高效存储和访问
/// </summary>
public unsafe class ChunkArray : IDisposable
{
	private ChunkArray_Native* _nativeArray;
	private bool _disposed = false;
	
	/// <summary>
	/// 获取数组是否有效
	/// </summary>
	public bool IsValid => _nativeArray != null && !_disposed;
	
	/// <summary>
	/// 获取数组中的元素数量
	/// </summary>
	public int Count => IsValid ? ChunkArrayDllImport.ChunkArray_GetItemCount(_nativeArray) : 0;
	
	/// <summary>
	/// 获取元素的大小（字节）
	/// </summary>
	public int ItemSize => IsValid ? ChunkArrayDllImport.ChunkArray_GetItemSize(_nativeArray) : 0;
	
	/// <summary>
	/// 获取原生ChunkArray指针
	/// </summary>
	internal ChunkArray_Native* NativeArrayPtr => _nativeArray;
	
	/// <summary>
	/// 创建一个新的ChunkArray实例
	/// </summary>
	/// <param name="itemSize">元素大小（字节）</param>
	/// <param name="countInChunk">每个块中可容纳的元素数量</param>
	/// <param name="initialCapacity">初始预分配的块数量</param>
	public ChunkArray(int itemSize, int countInChunk, int initialCapacity)
	{
		if (itemSize <= 0)
			throw new ArgumentException("Item size must be greater than zero", nameof(itemSize));
			
		if (countInChunk <= 0)
			throw new ArgumentException("Chunk size must be greater than zero", nameof(countInChunk));
			
		if (initialCapacity <= 0)
			throw new ArgumentException("Initial capacity must be greater than zero", nameof(initialCapacity));
			
		_nativeArray = ChunkArrayDllImport.ChunkArray_Create(countInChunk, itemSize, initialCapacity);
		
		if (_nativeArray == null)
			throw new InvalidOperationException("Failed to create chunk array");
	}
	
	/// <summary>
	/// 向数组中添加元素
	/// </summary>
	/// <param name="itemPtr">指向要添加元素的指针</param>
	/// <returns>新添加元素的索引，失败返回-1</returns>
	public int AddUnsafe(void* itemPtr)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (itemPtr == null)
			throw new ArgumentNullException(nameof(itemPtr));
			
		return ChunkArrayDllImport.ChunkArray_Add(_nativeArray, itemPtr);
	}
	
	
	/// <summary>
	/// 向数组中添加元素
	/// </summary>
	/// <param name="data">包含要添加元素数据的Span</param>
	/// <returns>新添加元素的索引，失败返回-1</returns>
	public int Add(ReadOnlySpan<byte> data)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (data.Length != ItemSize)
			throw new ArgumentException($"Data length ({data.Length}) does not match item size ({ItemSize})", nameof(data));
			
		fixed (byte* dataPtr = data)
		{
			return ChunkArrayDllImport.ChunkArray_Add(_nativeArray, dataPtr);
		}
	}
	
	/// <summary>
	/// 获取指定索引处的元素指针
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指向元素的指针</returns>
	public void* GetUnsafe(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		void* itemPtr = ChunkArrayDllImport.ChunkArray_Get(_nativeArray, index);
		if (itemPtr == null)
			throw new InvalidOperationException($"Failed to get item at index {index}");
			
		return itemPtr;
	}
	
	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <param name="destination">用于存储元素数据的目标缓冲区</param>
	/// <returns>true表示成功，false表示失败</returns>
	public bool Get(int index, Span<byte> destination)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		if (destination.Length < ItemSize)
			throw new ArgumentException($"Destination buffer length ({destination.Length}) is less than item size ({ItemSize})", nameof(destination));
			
		void* itemPtr = ChunkArrayDllImport.ChunkArray_Get(_nativeArray, index);
		if (itemPtr == null)
			return false;
			
		fixed (byte* destPtr = destination)
		{
			Buffer.MemoryCopy(itemPtr, destPtr, destination.Length, ItemSize);
			return true;
		}
	}
	
	/// <summary>
	/// 移除指定索引处的元素
	/// </summary>
	/// <param name="index">要移除的元素的索引</param>
	public void Remove(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		ChunkArrayDllImport.ChunkArray_Remove(_nativeArray, index);
	}
	
	/// <summary>
	/// 释放资源
	/// </summary>
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	/// <summary>
	/// 释放资源的保护方法
	/// </summary>
	/// <param name="disposing">是否由Dispose方法调用</param>
	private void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (_nativeArray != null)
			{
				ChunkArrayDllImport.ChunkArray_Destroy(_nativeArray);
				_nativeArray = null;
			}
			
			_disposed = true;
		}
	}
	
	/// <summary>
	/// 析构函数
	/// </summary>
	~ChunkArray()
	{
		Dispose(false);
	}
}

/// <summary>
/// 泛型分块数组，提供对原生ChunkArray的类型安全的C#包装，适用于大规模数据的高效存储和访问
/// </summary>
/// <typeparam name="T">必须是非托管类型</typeparam>
public sealed unsafe class ChunkArray<T> : ChunkArray where T : unmanaged
{
	/// <summary>
	/// 创建一个新的ChunkArray实例
	/// </summary>
	/// <param name="countInChunk">每个块中可容纳的元素数量</param>
	/// <param name="initialCapacity">初始预分配的块数量</param>
	public ChunkArray(int countInChunk, int initialCapacity)
		: base(Unsafe.SizeOf<T>(), countInChunk, initialCapacity)
	{
	}
	
	/// <summary>
	/// 向数组中添加元素
	/// </summary>
	/// <param name="item">要添加的元素</param>
	/// <returns>新添加元素的索引，失败返回-1</returns>
	public int Add(T item)
	{
		return AddUnsafe(&item);
	}
	
	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public T Get(int index)
	{
		void* itemPtr = GetUnsafe(index);
		return *(T*)itemPtr;
	}
	
	/// <summary>
	/// 通过索引器访问元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public T this[int index]
	{
		get => Get(index);
	}
	
	/// <summary>
	/// 将数组中的元素复制到目标数组
	/// </summary>
	/// <param name="array">目标数组</param>
	/// <param name="arrayIndex">目标数组的起始索引</param>
	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		if (arrayIndex < 0)
			throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Starting index must be non-negative");
			
		if (array.Length - arrayIndex < Count)
			throw new ArgumentException("Destination array is not long enough");
			
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			array[arrayIndex + i] = Get(i);
		}
	}
	
	/// <summary>
	/// 将数组内容转换为托管数组
	/// </summary>
	/// <returns>包含所有元素的新数组</returns>
	public T[] ToArray()
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		int count = Count;
		T[] result = new T[count];
		CopyTo(result, 0);
		return result;
	}
	
	/// <summary>
	/// 从托管数组创建一个新的ChunkArray
	/// </summary>
	/// <param name="array">源数组</param>
	/// <param name="chunkSize">每个块中可容纳的元素数量</param>
	/// <returns>新创建的ChunkArray实例</returns>
	public static ChunkArray<T> FromArray(T[] array, int chunkSize = 1024)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		if (chunkSize <= 0)
			throw new ArgumentException("Chunk size must be greater than zero", nameof(chunkSize));
			
		// 计算需要的块数量
		int initialCapacity = (array.Length + chunkSize - 1) / chunkSize;
		if (initialCapacity < 1) initialCapacity = 1;
		
		// 创建ChunkArray实例
		ChunkArray<T> chunkArray = new ChunkArray<T>(chunkSize, initialCapacity);
		
		// 添加所有元素
		foreach (T item in array)
		{
			chunkArray.Add(item);
		}
		
		return chunkArray;
	}
}

internal unsafe static class ChunkArrayDllImport
{
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern ChunkArray_Native* ChunkArray_Create(int chunkCount, int itemSize, int capcity);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Destroy(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_GetItemCount(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_GetItemSize(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_Add(ChunkArray_Native* arr, void* item);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void* ChunkArray_Get(ChunkArray_Native* arr, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Remove(ChunkArray_Native* arr, int index);
}