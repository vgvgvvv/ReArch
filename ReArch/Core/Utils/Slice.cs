using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReArch.Core.Utils;

public unsafe ref struct Slice
{
	public Slice(IntPtr firstItem, int length, int itemSize)
	{
		FirstItem = firstItem;
		Length = length;
		ItemSize = itemSize;
	}
	
	public IntPtr FirstItem;
	public readonly int Length;
	public readonly int ItemSize;
	
	public Slice GetSubSlice(int start, int length)
	{
		if (start < 0 || start >= Length)
			throw new ArgumentOutOfRangeException(nameof(start), $"Start index {start} is out of range [0, {Length})");
			
		if (length < 0 || start + length > Length)
			throw new ArgumentOutOfRangeException(nameof(length), $"Length {length} is out of range [0, {Length - start})");
			
		return new Slice(FirstItem + start * ItemSize, length, ItemSize);
	}
	
}

public unsafe ref struct Slice<T> where T : unmanaged
{

	public Slice(T [] arr)
	{
		fixed (T* firstItem = &arr [0])
		{
			FirstItem = firstItem;
			Length = arr.Length;
			ItemSize = Unsafe.SizeOf<T>();
		}
	}

	public Slice(T* firstItem, int length)
	{
		FirstItem = firstItem;
		Length = length;
		ItemSize = Unsafe.SizeOf<T>();
	}
	
	public ref T this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
				throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range [0, {Length})");

			return ref *(FirstItem + index * ItemSize);
		}
	}
	
	public T* FirstItem;
	public readonly int Length;
	public readonly int ItemSize;
	
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	public ref struct Enumerator
	{
		private Slice<T> _slice;
		private int _index;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Enumerator(Slice<T> slice)
		{
			this._slice = slice;
			this._index = -1;
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool MoveNext()
		{
			int num = this._index + 1;
			if (num >= this._slice.Length)
				return false;
			this._index = num;
			return true;
		}
		
		public ref T Current
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref this._slice[this._index];
		}
	}

}