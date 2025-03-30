using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

/// <summary>
/// 位集合类，提供对原生BitSet的C#包装
/// </summary>
public sealed class BitSet : IDisposable
{
	private const int BitSize = (sizeof(uint) * 8) - 1;           // 31
	private const int IndexSize = 5;                              // log_2(BitSize + 1)
	private static readonly int _padding = Vector<uint>.Count;

	public readonly static BitSet Default = new BitSet(_padding);
	
	public static int RequiredLength(int id)
	{
		return (int)Math.Ceiling((float)id / BitSize);
	}
	
	public IntPtr BitSetPtr { get; private set; }
	private int _highestBit;
	private bool _disposed = false;
	
	/// <summary>
	/// 获取BitSet是否有效
	/// </summary>
	public bool IsValid => BitSetPtr != IntPtr.Zero && !_disposed;
	
	/// <summary>
	/// 获取最高位的索引（即位集合的容量-1）
	/// </summary>
	public int HighestBit => _highestBit;


	/// <summary>
	/// 创建一个新的BitSet实例
	/// </summary>
	/// <param name="highestBit">最高位的索引（位集合的容量-1）</param>
	public BitSet(int highestBit)
	{
		if (highestBit < 0)
			throw new ArgumentException("HighestBit must be non-negative", nameof(highestBit));
			
		BitSetPtr = BitSetDllImport.BitSet_Create(highestBit);
		
		if (BitSetPtr == IntPtr.Zero)
			throw new InvalidOperationException("Failed to create bit set");
			
		_highestBit = highestBit;
	}
	
	/// <summary>
	/// 检查指定位是否被设置
	/// </summary>
	/// <param name="index">要检查的位索引</param>
	/// <returns>如果位被设置则为true，否则为false</returns>
	public bool IsSet(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_IsSet(BitSetPtr, index);
	}
	
	/// <summary>
	/// 设置指定位
	/// </summary>
	/// <param name="index">要设置的位索引</param>
	/// <returns>操作是否成功</returns>
	public bool SetBit(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_SetBit(BitSetPtr, index);
	}
	
	/// <summary>
	/// 清除指定位
	/// </summary>
	/// <param name="index">要清除的位索引</param>
	/// <returns>操作是否成功</returns>
	public bool ClearBit(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_ClearBit(BitSetPtr, index);
	}
	
	/// <summary>
	/// 设置所有位
	/// </summary>
	public void SetAll()
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		BitSetDllImport.BitSet_SetAll(BitSetPtr);
	}
	
	/// <summary>
	/// 清除所有位
	/// </summary>
	public void ClearAll()
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		BitSetDllImport.BitSet_ClearAll(BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否包含指定BitSet的所有位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果当前BitSet包含指定BitSet的所有位，则为true</returns>
	public bool All(BitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (other == null)
			throw new ArgumentNullException(nameof(other));
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_All(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet有任何重叠的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果有任何重叠的位，则为true</returns>
	public bool Any(BitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (other == null)
			throw new ArgumentNullException(nameof(other));
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_Any(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet没有任何重叠的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果没有任何重叠的位，则为true</returns>
	public bool None(BitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (other == null)
			throw new ArgumentNullException(nameof(other));
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_None(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet有互斥的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果有互斥的位，则为true</returns>
	public bool Exclusive(BitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (other == null)
			throw new ArgumentNullException(nameof(other));
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_Exclusive(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 通过索引器访问或修改位
	/// </summary>
	/// <param name="index">位的索引</param>
	/// <returns>位的值</returns>
	public bool this[int index]
	{
		get => IsSet(index);
		set
		{
			if (value)
				SetBit(index);
			else
				ClearBit(index);
		}
	}
	
	/// <summary>
	/// 从另一个BitSet复制位
	/// </summary>
	/// <param name="source">源BitSet</param>
	public void CopyFrom(BitSet source)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (source == null)
			throw new ArgumentNullException(nameof(source));
			
		if (!source.IsValid)
			throw new InvalidOperationException("Source BitSet is not valid");
			
		// 首先清除所有位
		ClearAll();
		
		// 复制每一位
		int minHighestBit = Math.Min(_highestBit, source._highestBit);
		for (int i = 0; i <= minHighestBit; i++)
		{
			if (source.IsSet(i))
				SetBit(i);
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
	private void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (BitSetPtr != IntPtr.Zero)
			{
				BitSetDllImport.BitSet_Destroy(BitSetPtr);
				BitSetPtr = IntPtr.Zero;
			}
			
			_disposed = true;
		}
	}
	
	/// <summary>
	/// 析构函数
	/// </summary>
	~BitSet()
	{
		Dispose(false);
	}
	
	
}

public unsafe ref struct SliceBitSet
{
	private IntPtr BitSetPtr;
	private int _highestBit;
	
	/// <summary>
	/// 获取BitSet是否有效
	/// </summary>
	public bool IsValid => BitSetPtr != IntPtr.Zero;


	public SliceBitSet(Slice<uint> uints, int highestBit)
	{
		BitSetPtr = BitSetDllImport.BitSet_FromPtr(uints.FirstItem, uints.Length, highestBit);
		_highestBit = highestBit;
	}
	
		/// <summary>
	/// 检查指定位是否被设置
	/// </summary>
	/// <param name="index">要检查的位索引</param>
	/// <returns>如果位被设置则为true，否则为false</returns>
	public bool IsSet(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_IsSet(BitSetPtr, index);
	}
	
	/// <summary>
	/// 设置指定位
	/// </summary>
	/// <param name="index">要设置的位索引</param>
	/// <returns>操作是否成功</returns>
	public bool SetBit(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_SetBit(BitSetPtr, index);
	}
	
	/// <summary>
	/// 清除指定位
	/// </summary>
	/// <param name="index">要清除的位索引</param>
	/// <returns>操作是否成功</returns>
	public bool ClearBit(int index)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (index < 0 || index > _highestBit)
			throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {_highestBit}]");
			
		return BitSetDllImport.BitSet_ClearBit(BitSetPtr, index);
	}
	
	/// <summary>
	/// 设置所有位
	/// </summary>
	public void SetAll()
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		BitSetDllImport.BitSet_SetAll(BitSetPtr);
	}
	
	/// <summary>
	/// 清除所有位
	/// </summary>
	public void ClearAll()
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		BitSetDllImport.BitSet_ClearAll(BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否包含指定BitSet的所有位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果当前BitSet包含指定BitSet的所有位，则为true</returns>
	public bool All(SliceBitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_All(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet有任何重叠的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果有任何重叠的位，则为true</returns>
	public bool Any(SliceBitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_Any(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet没有任何重叠的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果没有任何重叠的位，则为true</returns>
	public bool None(SliceBitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_None(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 检查当前BitSet是否与指定BitSet有互斥的位
	/// </summary>
	/// <param name="other">要比较的BitSet</param>
	/// <returns>如果有互斥的位，则为true</returns>
	public bool Exclusive(SliceBitSet other)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (!other.IsValid)
			throw new InvalidOperationException("Other BitSet is not valid");
			
		return BitSetDllImport.BitSet_Exclusive(BitSetPtr, other.BitSetPtr);
	}
	
	/// <summary>
	/// 通过索引器访问或修改位
	/// </summary>
	/// <param name="index">位的索引</param>
	/// <returns>位的值</returns>
	public bool this[int index]
	{
		get => IsSet(index);
		set
		{
			if (value)
				SetBit(index);
			else
				ClearBit(index);
		}
	}
	
	/// <summary>
	/// 从另一个BitSet复制位
	/// </summary>
	/// <param name="source">源BitSet</param>
	public void CopyFrom(SliceBitSet source)
	{
		if (!IsValid)
			throw new InvalidOperationException("BitSet is not valid");
			
		if (!source.IsValid)
			throw new InvalidOperationException("Source BitSet is not valid");
			
		// 首先清除所有位
		ClearAll();
		
		// 复制每一位
		int minHighestBit = Math.Min(_highestBit, source._highestBit);
		for (int i = 0; i <= minHighestBit; i++)
		{
			if (source.IsSet(i))
				SetBit(i);
		}
	}
	

}

internal static unsafe class BitSetDllImport
{
	// P/Invoke 导入原生方法
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static IntPtr BitSet_Create(int highestBit);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static IntPtr BitSet_FromPtr(uint* bits, int uintSize, int highestBit);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static void BitSet_Destroy(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static IntPtr BitSet_GetBitPtr(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static int BitSet_GetHighestBit(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static int BitSet_GetMax(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_IsSet(IntPtr bitset, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_SetBit(IntPtr bitset, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_ClearBit(IntPtr bitset, int index);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static void BitSet_SetAll(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static void BitSet_ClearAll(IntPtr bitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_All(IntPtr bitset, IntPtr otherBitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_Any(IntPtr bitset, IntPtr otherBitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_None(IntPtr bitset, IntPtr otherBitset);
	[DllImport(DllImport.ReArchNativeDll)]
	public extern static bool BitSet_Exclusive(IntPtr bitset, IntPtr otherBitset);
}