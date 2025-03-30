using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

internal struct Slot
{
	public int IndexOfChunk;
	public int IndexInChunk;
};

internal unsafe struct Chunk
{
	public int ItemSizeInByte;
	public int ItemCount;
	public void* Data;
};

internal unsafe struct ChunkArray_Native
{
	public int ItemSizeInByte;
	public int ItemCount;
	public int ChunkCount;
	public int ChunkSizeInBytes;

	public Chunk* Chunks;
};

/// <summary>
/// 分块数组，提供对原生ChunkArray的C#包装，适用于大规模数据的高效存储和访问
/// </summary>
public abstract unsafe class ChunkArray : IDisposable
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
	
	public int Capacity => IsValid ? _nativeArray->ChunkCount * _nativeArray->ItemCount : 0;
	
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
	
	public int AddDefault()
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
		return ChunkArrayDllImport.ChunkArray_AddDefault(NativeArrayPtr);
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

	public void AddRange(void* ptr, int count)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (ptr == null)
			throw new ArgumentNullException(nameof(ptr));
			
		if (count <= 0)
			throw new ArgumentException("Count must be greater than zero", nameof(count));
			
		ChunkArrayDllImport.ChunkArray_AddRange(_nativeArray, ptr, count);
	}
	
	public void AddRangeDefault(int count)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (count <= 0)
			throw new ArgumentException("Count must be greater than zero", nameof(count));
			
		ChunkArrayDllImport.ChunkArray_AddDefaultRange(_nativeArray, count);
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

	public abstract object GetObject(int index);
	
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

	public void RemoveRange(int index, int count)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		if (count < 0)
			throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
			
		if (index + count > Count)
			throw new ArgumentException($"Range [index, index + count) = [{index}, {index + count}) is outside array bounds [0, {Count})");
			
		// 循环移除指定范围内的元素
		for (int i = 0; i < count; i++)
		{
			ChunkArrayDllImport.ChunkArray_Remove(_nativeArray, index);
		}
	}
	
	public void Set(int index, Slice<byte> data)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index >= Count)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		if (data.Length != ItemSize)
			throw new ArgumentException($"Data length ({data.Length}) does not match item size ({ItemSize})", nameof(data));
			
		ChunkArrayDllImport.ChunkArray_Set(_nativeArray, index, data.FirstItem);
	}

	public void SetRange(int index, int count, Slice<byte> data)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index + count >= Count || count < 0)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		if (data.Length != ItemSize)
			throw new ArgumentException($"Data length ({data.Length}) does not match item size ({ItemSize})", nameof(data));
		
		ChunkArrayDllImport.ChunkArray_SetRange(_nativeArray, index, count, data.FirstItem);
	}

	
	public void EnsureCapacity(int count)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (count < 0)
			throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
			
		ChunkArrayDllImport.ChunkArray_EnsureCapacity(_nativeArray, count);
	}
	
	public void TrimExcess()
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		ChunkArrayDllImport.ChunkArray_TrimExcess(_nativeArray);
	}
	
	public void Clear()
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		ChunkArrayDllImport.ChunkArray_Clear(_nativeArray);
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
	/// 向数组中添加一组元素
	/// </summary>
	/// <param name="items">要添加的元素集合</param>
	public void AddRange(Slice<T> items)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (items.Length == 0)
			return;
			
		AddRange(items.FirstItem, items.Length);
	}

	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public ref T Get(int index)
	{
		void* itemPtr = GetUnsafe(index);
		return ref *(T*)itemPtr;
	}
	
	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index"></param>
	/// <param name="item"></param>
	public void Set(int index, T item)
	{
		byte* data = stackalloc byte[ItemSize];
		*(T*) data = item;
		Set(index, new Slice<byte>(data, ItemSize));
	}
	
	/// <summary>
	/// 设置指定范围内的元素
	/// </summary>
	/// <param name="index"></param>
	/// <param name="count"></param>
	/// <param name="item"></param>
	/// <exception cref="InvalidOperationException"></exception>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public void SetRange(int index, int count, T item)
	{
		if (!IsValid)
			throw new InvalidOperationException("Chunk array is not valid");
			
		if (index < 0 || index + count >= Count || count < 0)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Count - 1}]");
			
		byte* data = stackalloc byte[ItemSize];
		*(T*) data = item;
		SetRange(index, count, new Slice<byte>(data, ItemSize));
	}
	
	/// <summary>
	/// 通过索引器访问元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public ref T this[int index]
	{
		get => ref Get(index);
	}

	public override object GetObject(int index)
	{
		return this [index];
	}

	public void Copy(ChunkArray<T> from, int fromIndex, ChunkArray<T> to, int toIndex, int count)
	{
		if (from == null)
			throw new ArgumentNullException(nameof(from));
			
		if (to == null) 
			throw new ArgumentNullException(nameof(to));
			
		if (!from.IsValid)
			throw new InvalidOperationException("Source chunk array is not valid");
			
		if (!to.IsValid)
			throw new InvalidOperationException("Destination chunk array is not valid");
			
		if (fromIndex < 0 || fromIndex >= from.Count)
			throw new ArgumentOutOfRangeException(nameof(fromIndex), $"Index {fromIndex} is out of range [0, {from.Count - 1}]");
			
		if (toIndex < 0 || toIndex >= to.Count)
			throw new ArgumentOutOfRangeException(nameof(toIndex), $"Index {toIndex} is out of range [0, {to.Count - 1}]");
			
		if (count < 0)
			throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
			
		if (fromIndex + count > from.Count)
			throw new ArgumentException($"Source range [fromIndex, fromIndex + count) = [{fromIndex}, {fromIndex + count}) is outside array bounds [0, {from.Count})");
			
		if (toIndex + count > to.Count)
			throw new ArgumentException($"Destination range [toIndex, toIndex + count) = [{toIndex}, {toIndex + count}) is outside array bounds [0, {to.Count})");
			
		ChunkArrayDllImport.ChunkArray_Copy(from.NativeArrayPtr, fromIndex, to.NativeArrayPtr, toIndex, count);
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
	public static extern int ChunkArray_AddDefault(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_AddRange(ChunkArray_Native* arr, void* item, int count);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern int ChunkArray_AddDefaultRange(ChunkArray_Native* arr, int count);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void* ChunkArray_Get(ChunkArray_Native* arr, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Remove(ChunkArray_Native* arr, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_RemoveRange(ChunkArray_Native* arr, int index, int count);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Set(ChunkArray_Native* arr, int index, void* item);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_SetRange(ChunkArray_Native* arr, int index, int count, void* item);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_EnsureCapacity(ChunkArray_Native* arr, int count);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_TrimExcess(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Clear(ChunkArray_Native* arr);
	[DllImport(DllImport.ReArchNativeDll)]
	public static extern void ChunkArray_Copy(ChunkArray_Native* from, int fromIndex, ChunkArray_Native* to, int toIndex, int count);
}



public static class ArrayRegistry
{
	private static readonly Dictionary<int, Func<int, int, ChunkArray>> _createFactories = new(128);

	/// <summary>
	///     Adds a new array type and registers it.
	/// </summary>
	/// <typeparam name="T">The type of the array.</typeparam>
	public static void Add<T>() where T : unmanaged
	{
		_createFactories.Add(Component<T>.ComponentType.Id, ArrayFactory<T>.Create);
	}

	/// <summary>
	///     Gets an array of the specified type and capacity. Will use the registered factory if it exists, otherwise it will create a new array using reflection.
	/// </summary>
	/// <param name="type">The type of the array.</param>
	/// <param name="capacity">The capacity of the array.</param>
	/// <returns>The created array.</returns>
	public static ChunkArray GetArray(ComponentType type, int countInChunk, int capacity)
	{
		return _createFactories.TryGetValue(type.Id, out Func<int, int, ChunkArray> func) ? 
			func(countInChunk, capacity) : 
			throw new NotSupportedException($"cannot create chunk array for {type.Type}");
	}

	/// <summary>
	///     An array factory that creates arrays of the specified type.
	/// </summary>
	/// <typeparam name="T">The type of the array.</typeparam>
	private static class ArrayFactory<T> where T : unmanaged
	{
		public static readonly Func<int, int, ChunkArray> Create = (countInChunk, capacity) => new ChunkArray<T>(countInChunk, capacity);
	}
}
