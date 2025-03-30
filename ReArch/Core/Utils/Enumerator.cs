using System;
using System.Runtime.CompilerServices;

namespace ReArch.Core.Utils;

[SkipLocalsInit]
public unsafe ref struct Enumerator<T> where T : unmanaged
{

	private readonly T* _ptr;
	private int _index;
	private readonly int _length;

	/// <summary>
	///     Initializes a new instance of the <see cref="Enumerator{T}"/> struct.
	/// </summary>
	/// <param name="slice">The <see cref="Span{T}"/> with items to iterate over.</param>
	public Enumerator(Slice<T> slice)
	{

		_ptr = slice.FirstItem;
		_length = slice.Length;
		_index = _length;
	}

	/// <summary>
	///     Moves to the next item.
	/// </summary>
	/// <returns>True if there still items, otherwise false.</returns>

	public bool MoveNext()
	{
		return unchecked(--_index) >= 0;
	}

	/// <summary>
	///     Resets this instance.
	/// </summary>

	public void Reset()
	{
		_index = _length;
	}

	/// <summary>
	///     Returns a reference to the current item.
	/// </summary>
	public readonly ref T Current
	{

		get {
			return ref _ptr [_index];
		}
	}
}
