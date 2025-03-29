using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

public class NativeArray
{
	
	protected IntPtr NativeArrayPtr = IntPtr.Zero;
	private bool _disposed = false;
	
	/// <summary>
	/// 检查数组是否有效
	/// </summary>
	public bool IsValid => NativeArrayPtr != IntPtr.Zero && !_disposed;
	
	/// <summary>
	/// 获取数组中的元素数量
	/// </summary>
	public readonly int Count;

	public readonly int ItemSize;

	/// <summary>
	/// 创建一个新的NativeArray实例
	/// </summary>
	/// <param name="itemSize">Item尺寸</param>
	/// <param name="count">数组中的元素数量</param>
	public NativeArray(int itemSize, int count)
	{
		if (count <= 0)
			throw new ArgumentException("Count must be greater than zero", nameof(count));
			
		NativeArrayPtr = NativeArray_Create(itemSize, count);
		
		if (NativeArrayPtr == IntPtr.Zero)
			throw new InvalidOperationException("Failed to create native array");

		ItemSize = itemSize;
		Count = count;
	}
	
	/// <summary>
	/// 清除数组中的所有元素（设置为默认值）
	/// </summary>
	public void Clear()
	{
		if (!IsValid)
			throw new InvalidOperationException("Native array is not valid");
			
		NativeArray_Clear(NativeArrayPtr);
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
			if (NativeArrayPtr != IntPtr.Zero)
			{
				NativeArray_Destroy(NativeArrayPtr);
				NativeArrayPtr = IntPtr.Zero;
			}
			
			_disposed = true;
		}
	}
	
	/// <summary>
	/// 析构函数
	/// </summary>
	~NativeArray()
	{
		Dispose(false);
	}
	
	#region DllImport
	// P/Invoke 导入原生方法
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern IntPtr NativeArray_Create(int itemSize, int itemCount);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern void NativeArray_Destroy(IntPtr array);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern void NativeArray_Clear(IntPtr array);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern void NativeArray_Set(IntPtr array, int index, IntPtr value);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern IntPtr NativeArray_Get(IntPtr array, int index);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern int NativeArray_GetSize(IntPtr array);
	
	[DllImport(DllImport.ReArchNativeDll)]
	protected static extern int NativeArray_GetItemSize(IntPtr array);
	#endregion
	
	
	
}

/// <summary>
/// 泛型原生数组包装类，提供对原生NativeArray的C#包装
/// </summary>
/// <typeparam name="T">必须是值类型</typeparam>
public unsafe class NativeArray<T> : NativeArray, IDisposable where T : unmanaged
{

	/// <summary>
	/// 从托管数组创建一个新的NativeArray
	/// </summary>
	/// <param name="array">源托管数组</param>
	/// <returns>新创建的NativeArray实例</returns>
	public static NativeArray<T> FromArray(T[] array)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		NativeArray<T> nativeArray = new NativeArray<T>(Unsafe.SizeOf<T>(), array.Length);
		
		// 逐个设置元素
		for (int i = 0; i < array.Length; i++)
		{
			nativeArray[i] = array[i];
		}
		
		return nativeArray;
	}
	
	public NativeArray(int itemSize, int count) : base(itemSize, count)
	{
	}

	/// <summary>
	/// 获取或设置指定索引处的元素
	/// </summary>
	/// <param name="index">要获取或设置的元素的索引</param>
	/// <returns>指定索引处的元素</returns>
	public T this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
				throw new IndexOutOfRangeException($"Index {index} is out of range [0, {Count - 1}]");
				
			if (!IsValid)
				throw new InvalidOperationException("Native array is not valid");
				
			IntPtr ptr = NativeArray_Get(NativeArrayPtr, index);
			if (ptr == IntPtr.Zero)
			{
				return default;
			}
			return *(T*) ptr.ToPointer();
		}
		set
		{
			if (index < 0 || index >= Count)
				throw new IndexOutOfRangeException($"Index {index} is out of range [0, {Count - 1}]");
				
			if (!IsValid)
				throw new InvalidOperationException("Native array is not valid");
			
			NativeArray_Set(NativeArrayPtr, index, new IntPtr(&value));
		}
	}
	
	
	
	/// <summary>
	/// 将数组中的元素复制到现有的托管数组中
	/// </summary>
	/// <param name="array">目标托管数组</param>
	/// <param name="arrayIndex">目标数组的起始索引</param>
	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
			throw new ArgumentNullException(nameof(array));
			
		if (arrayIndex < 0)
			throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Index must be non-negative");
			
		if (array.Length - arrayIndex < Count)
			throw new ArgumentException("Destination array is not long enough");
			
		if (!IsValid)
			throw new InvalidOperationException("Native array is not valid");
			
		// 逐个复制元素
		for (int i = 0; i < Count; i++)
		{
			array[arrayIndex + i] = this[i];
		}
	}
	
}


