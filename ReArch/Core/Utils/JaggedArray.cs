using System;
using System.Collections;
using System.Collections.Generic;

namespace ReArch.Core.Utils;

/// <summary>
/// 托管块，用于存储一组相同类型的托管对象
/// </summary>
/// <typeparam name="T">元素类型，可以是任何类型</typeparam>
public class JaggedChunk<T>
{
	/// <summary>
	/// 每个元素的大小（仅用于统计）
	/// </summary>
	public int ItemSize;
	
	/// <summary>
	/// 当前块中的元素数量
	/// </summary>
	public int ItemCount;
	
	/// <summary>
	/// 用于存储元素的数组
	/// </summary>
	public T[] Data;
	
	/// <summary>
	/// 标记哪些位置包含有效数据（非默认值）
	/// </summary>
	public bool[] IsValid;
}

/// <summary>
/// 托管分块数组，提供对大量托管对象的高效存储和访问
/// 不需要unmanaged约束，可以存储任何类型的对象
/// 移除元素时不移动数据，而是标记位置为无效
/// </summary>
/// <typeparam name="T">元素类型，可以是任何类型</typeparam>
public class JaggedArray<T> : IEnumerable<T>, IDisposable
{
	private readonly int _countInChunk;
	private JaggedChunk<T>[] _chunks;
	private int _chunkCount;
	private int _totalCount;         // 总元素数量（包括被标记为删除的）
	private int _validCount;         // 有效元素数量
	private bool _disposed;
	private T _defaultValue;
	
	/// <summary>
	/// 获取数组中有效元素的数量
	/// </summary>
	public int Count => _validCount;
	
	/// <summary>
	/// 获取数组的总容量（包括被删除的元素位置）
	/// </summary>
	public int Capacity => _totalCount;
	
	/// <summary>
	/// 获取每个块可容纳的元素数量
	/// </summary>
	public int CountInChunk => _countInChunk;
	
	/// <summary>
	/// 获取当前已分配的块数量
	/// </summary>
	public int ChunkCount => _chunkCount;
	
	/// <summary>
	/// 创建一个新的托管分块数组
	/// </summary>
	/// <param name="countInChunk">每个块中可容纳的元素数量</param>
	/// <param name="initialChunkCount">初始预分配的块数量</param>
	/// <param name="defaultValue">标记删除元素的默认值</param>
	public JaggedArray(int countInChunk, int initialChunkCount, T defaultValue = default)
	{
		if (countInChunk <= 0)
			throw new ArgumentException("Count in chunk must be greater than zero", nameof(countInChunk));
			
		if (initialChunkCount <= 0)
			throw new ArgumentException("Initial chunk count must be greater than zero", nameof(initialChunkCount));
			
		_countInChunk = countInChunk;
		_chunks = new JaggedChunk<T>[initialChunkCount];
		_chunkCount = initialChunkCount;
		_totalCount = 0;
		_validCount = 0;
		_defaultValue = defaultValue;
		
		// 初始化所有块
		for (int i = 0; i < initialChunkCount; i++)
		{
			_chunks[i] = new JaggedChunk<T>
			{
				ItemSize = typeof(T).IsValueType ? System.Runtime.InteropServices.Marshal.SizeOf<T>() : IntPtr.Size,
				ItemCount = 0,
				Data = new T[countInChunk],
				IsValid = new bool[countInChunk]
			};
		}
	}
	
	/// <summary>
	/// 通过索引器访问或修改元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public ref T this[int index]
	{
		get => ref Get(index);
	}
	
	/// <summary>
	/// 设置或添加元素
	/// </summary>
	/// <param name="item">要添加的元素</param>
	/// <returns>新添加元素的索引</returns>
	public int SetOrAdd(T item)
	{
		var id = GetFirstEmptyIndex();
		if (id != -1)
		{
			Set(id, item);
			return id;
		}
		
		// 添加到末尾
		EnsureCapacity(_totalCount + 1);
		
		// 计算目标块和块内索引
		int chunkIndex = _totalCount / _countInChunk;
		int indexInChunk = _totalCount % _countInChunk;
		
		// 设置数据和有效性标志
		JaggedChunk<T> chunk = _chunks[chunkIndex];
		chunk.Data[indexInChunk] = item;
		chunk.IsValid[indexInChunk] = true;
		chunk.ItemCount++;
		
		int index = _totalCount;
		_totalCount++;
		_validCount++;
		return index;
	}


	/// <summary>
	/// 获取第一个空闲位置的索引
	/// </summary>
	/// <returns>第一个空闲位置的索引，如果未找到则返回-1</returns>
	public int GetFirstEmptyIndex()
	{
		for (int i = 0; i < _totalCount; i++)
		{
			if (!IsValid(i)) 
				return i;
		}
		return -1;
	}
	
	/// <summary>
	/// 获取指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public ref T Get(int index)
	{
		if (index < 0 || index >= _totalCount)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_totalCount - 1}]");
			
		// 计算块索引和块内索引
		int chunkIndex = index / _countInChunk;
		int indexInChunk = index % _countInChunk;
		
		// 检查该位置是否有效
		JaggedChunk<T> chunk = _chunks[chunkIndex];
		if (!chunk.IsValid[indexInChunk])
			throw new InvalidOperationException($"Element at index {index} has been removed");
		
		// 返回元素
		return ref chunk.Data[indexInChunk];
	}

	/// <summary>
	/// 安全获取指定索引处的元素，如果已删除则返回默认值
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <param name="result">输出参数，用于返回元素值</param>
	/// <param name="defaultValueIfRemoved">如果元素已被删除，返回的默认值</param>
	/// <returns>如果索引有效，返回true，否则返回false</returns>
	public bool TryGet(int index, out T result, T defaultValueIfRemoved = default)
	{
		if (index < 0 || index >= _totalCount)
		{
			result = defaultValueIfRemoved;
			return false;
		}
			
		// 计算块索引和块内索引
		int chunkIndex = index / _countInChunk;
		int indexInChunk = index % _countInChunk;
		
		// 检查该位置是否有效
		JaggedChunk<T> chunk = _chunks[chunkIndex];
		if (!chunk.IsValid [indexInChunk])
		{
			result = defaultValueIfRemoved;
			return false;
		}
		
		// 返回元素
		result = chunk.Data[indexInChunk];
		return true;
	}
	
	/// <summary>
	/// 检查索引处的元素是否有效（未被删除）
	/// </summary>
	/// <param name="index">要检查的索引</param>
	/// <returns>如果元素有效返回true，否则返回false</returns>
	public bool IsValid(int index)
	{
		if (index < 0 || index >= _totalCount)
			return false;
			
		int chunkIndex = index / _countInChunk;
		int indexInChunk = index % _countInChunk;
		
		return _chunks[chunkIndex].IsValid[indexInChunk];
	}
	
	/// <summary>
	/// 设置指定索引处的元素
	/// </summary>
	/// <param name="index">元素的索引</param>
	/// <param name="value">要设置的值</param>
	public void Set(int index, T value)
	{
		if (index < 0 || index >= _totalCount)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_totalCount - 1}]");
			
		// 计算块索引和块内索引
		int chunkIndex = index / _countInChunk;
		int indexInChunk = index % _countInChunk;
		
		// 获取目标块
		JaggedChunk<T> chunk = _chunks[chunkIndex];
		
		// 如果该位置之前无效（被删除过），现在重新变为有效
		if (!chunk.IsValid[indexInChunk])
		{
			_validCount++;
			chunk.ItemCount++;
		}
		
		// 设置元素和有效性标志
		chunk.Data[indexInChunk] = value;
		chunk.IsValid[indexInChunk] = true;
	}
	
	/// <summary>
	/// 移除指定索引处的元素，标记为无效
	/// </summary>
	/// <param name="index">要移除的元素的索引</param>
	public void Remove(int index)
	{
		if (index < 0 || index >= _totalCount)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_totalCount - 1}]");
			
		// 计算块索引和块内索引
		int chunkIndex = index / _countInChunk;
		int indexInChunk = index % _countInChunk;
		
		// 获取目标块
		JaggedChunk<T> chunk = _chunks[chunkIndex];
		
		// 如果该位置已经无效（已被删除），直接返回
		if (!chunk.IsValid[indexInChunk])
			return;
		
		// 设置为默认值并标记为无效
		chunk.Data[indexInChunk] = _defaultValue;
		chunk.IsValid[indexInChunk] = false;
		chunk.ItemCount--;
		
		// 更新有效元素计数
		_validCount--;
	}
	
	/// <summary>
	/// 清空数组中的所有元素
	/// </summary>
	public void Clear()
	{
		// 遍历所有已使用的块
		int usedChunks = (_totalCount + _countInChunk - 1) / _countInChunk;
		
		for (int i = 0; i < usedChunks; i++)
		{
			JaggedChunk<T> chunk = _chunks[i];
			
			// 清空数组元素和有效性标志
			Array.Clear(chunk.Data, 0, _countInChunk);
			Array.Clear(chunk.IsValid, 0, _countInChunk);
			
			// 重置计数
			chunk.ItemCount = 0;
		}
		
		// 重置计数
		_totalCount = 0;
		_validCount = 0;
	}
	
	/// <summary>
	/// 将数组中的所有有效元素复制到目标数组
	/// </summary>
	/// <param name="array">目标数组</param>
	/// <param name="arrayIndex">目标数组的起始索引</param>
	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		if (arrayIndex < 0)
			throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Starting index must be non-negative");
			
		if (array.Length - arrayIndex < _validCount)
			throw new ArgumentException("Destination array is not long enough");
			
		// 复制有效元素
		int currentIndex = arrayIndex;
		int usedChunks = (_totalCount + _countInChunk - 1) / _countInChunk;
		
		for (int chunkIndex = 0; chunkIndex < usedChunks; chunkIndex++)
		{
			JaggedChunk<T> chunk = _chunks[chunkIndex];
			int itemsInChunk = Math.Min(_countInChunk, _totalCount - chunkIndex * _countInChunk);
			
			for (int i = 0; i < itemsInChunk; i++)
			{
				if (chunk.IsValid[i])
				{
					array[currentIndex++] = chunk.Data[i];
				}
			}
		}
	}
	
	/// <summary>
	/// 将数组中的所有有效元素转换为标准数组
	/// </summary>
	/// <returns>包含所有有效元素的新数组</returns>
	public T[] ToArray()
	{
		T[] result = new T[_validCount];
		CopyTo(result, 0);
		return result;
	}
	
	/// <summary>
	/// 从标准数组创建新的托管分块数组
	/// </summary>
	/// <param name="array">源数组</param>
	/// <param name="countInChunk">每个块中可容纳的元素数量</param>
	/// <param name="defaultValue">标记删除元素的默认值</param>
	/// <returns>新创建的托管分块数组</returns>
	public static JaggedArray<T> FromArray(T[] array, int countInChunk = 1024, T defaultValue = default)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		if (countInChunk <= 0)
			throw new ArgumentException("Count in chunk must be greater than zero", nameof(countInChunk));
			
		// 计算需要的块数量
		int requiredChunks = (array.Length + countInChunk - 1) / countInChunk;
		if (requiredChunks < 1) requiredChunks = 1;
		
		// 创建实例
		var result = new JaggedArray<T>(countInChunk, requiredChunks, defaultValue);
		
		// 添加元素
		foreach (T item in array)
		{
			result.SetOrAdd(item);
		}
		
		return result;
	}
	
	/// <summary>
	/// 确保数组有足够的容量容纳指定数量的元素
	/// </summary>
	/// <param name="minCapacity">需要的最小容量</param>
	public void EnsureCapacity(int minCapacity)
	{
		// 计算当前总容量
		int currentCapacity = _chunkCount * _countInChunk;
		
		// 如果当前容量足够，直接返回
		if (currentCapacity >= minCapacity)
			return;
			
		// 计算需要的块数量
		int requiredChunks = (minCapacity + _countInChunk - 1) / _countInChunk;
		
		// 扩展数组
		int newChunkCount = Math.Max(requiredChunks, _chunkCount * 2);
		Array.Resize(ref _chunks, newChunkCount);
		
		// 初始化新添加的块
		for (int i = _chunkCount; i < newChunkCount; i++)
		{
			_chunks[i] = new JaggedChunk<T>
			{
				ItemSize = typeof(T).IsValueType ? System.Runtime.InteropServices.Marshal.SizeOf<T>() : IntPtr.Size,
				ItemCount = 0,
				Data = new T[_countInChunk],
				IsValid = new bool[_countInChunk]
			};
		}
		
		// 更新块数量
		_chunkCount = newChunkCount;
	}
	
	/// <summary>
	/// 获取数组中所有有效元素的枚举器
	/// </summary>
	/// <returns>数组的枚举器</returns>
	public IEnumerator<T> GetEnumerator()
	{
		int usedChunks = (_totalCount + _countInChunk - 1) / _countInChunk;
		
		for (int chunkIndex = 0; chunkIndex < usedChunks; chunkIndex++)
		{
			JaggedChunk<T> chunk = _chunks[chunkIndex];
			int itemsInChunk = Math.Min(_countInChunk, _totalCount - chunkIndex * _countInChunk);
			
			for (int i = 0; i < itemsInChunk; i++)
			{
				if (chunk.IsValid[i])
				{
					yield return chunk.Data[i];
				}
			}
		}
	}
	
	/// <summary>
	/// 获取非泛型枚举器
	/// </summary>
	/// <returns>数组的非泛型枚举器</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
	
	/// <summary>
	/// 获取所有有效元素的索引枚举器
	/// </summary>
	/// <returns>索引枚举器</returns>
	public IEnumerable<int> GetValidIndexes()
	{
		int usedChunks = (_totalCount + _countInChunk - 1) / _countInChunk;
		
		for (int chunkIndex = 0; chunkIndex < usedChunks; chunkIndex++)
		{
			JaggedChunk<T> chunk = _chunks[chunkIndex];
			int itemsInChunk = Math.Min(_countInChunk, _totalCount - chunkIndex * _countInChunk);
			int baseIndex = chunkIndex * _countInChunk;
			
			for (int i = 0; i < itemsInChunk; i++)
			{
				if (chunk.IsValid[i])
				{
					yield return baseIndex + i;
				}
			}
		}
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
	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (disposing)
			{
				// 清除所有引用，帮助GC
				Clear();
				_chunks = null;
			}
			
			_disposed = true;
		}
	}
	
	/// <summary>
	/// 析构函数
	/// </summary>
	~JaggedArray()
	{
		Dispose(false);
	}
}