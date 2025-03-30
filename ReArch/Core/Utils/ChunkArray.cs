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

internal unsafe struct ChunkArray
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
/// <typeparam name="T">必须是非托管类型</typeparam>
public sealed unsafe class ChunkArray<T> : IDisposable where T : unmanaged
{
	private ChunkArray* _nativeArray;
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
	/// 创建一个新的ChunkArray实例
	/// </summary>
	/// <param name="chunkSize">每个块中可容纳的元素数量</param>
	/// <param name="initialCapacity">初始预分配的块数量</param>
	public ChunkArray(int chunkSize, int initialCapacity)
	{
		if (chunkSize <= 0)
			throw new ArgumentException("Chunk size must be greater than zero", nameof(chunkSize));
			
		if (initialCapacity <= 0)
			throw new ArgumentException("Initial capacity must be greater than zero", nameof(initialCapacity));
			
		int itemSize = Unsafe.SizeOf<T>();
		_nativeArray = ChunkArrayDllImport.ChunkArray_Create(chunkSize, itemSize, initialCapacity);
		
		if (_nativeArray == null)
			throw new InvalidOperationException("Failed to create chunk array");
	}
	
	/// <summary>
	/// 向数组中添加元素
	/// </summary>
	/// <param name="item">要添加的元素</param>
	/// <returns>新添加元素的索引，失败返回-1</returns>
	public int Add(T item)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
		
		return ChunkArrayDllImport.ChunkArray_Add(_nativeArray, &item);
	}
	
	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public T Get(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		void* itemPtr = ChunkArrayDllImport.ChunkArray_Get(_nativeArray, index);
		if (itemPtr == null)
			throw new InvalidOperationException($"Failed to get item at index {index}");
			
		return *(T*)itemPtr;
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
	protected void Dispose(bool disposing)
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

internal unsafe static class ChunkArrayDllImport
{
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern ChunkArray* ChunkArray_Create(int chunkCount, int itemSize, int capcity);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Destroy(ChunkArray* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_GetItemCount(ChunkArray* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_GetItemSize(ChunkArray* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_Add(ChunkArray* arr, void* item);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void* ChunkArray_Get(ChunkArray* arr, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Remove(ChunkArray* arr, int index);
}