using System;
using System.Buffers;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

internal unsafe class Pool<T>
{
    /// <summary>
    ///     The <see cref="PooledArray"/> struct
    ///     is a tracked pooled array instance of a given type that implements <see cref="IDisposable"/> and thus returns automatically.
    /// </summary>
    /// <param name="Array"></param>
    /// <param name="Length"></param>
    public readonly record struct PooledArray(T[] Array, int Length) : IDisposable
    {

        /// <summary>
        ///     Returns a reference to the item at the index.
        /// </summary>
        /// <param name="index">The index.</param>
        public ref T this[int index]
        {
            get => ref Array[index];
        }

        /// <summary>
        ///     Converts this instance to a <see cref="Span{T}"/>.
        /// </summary>
        /// <returns></returns>
        public Span<T> AsSpan()
        {
            return MemoryMarshal.CreateSpan(ref this[0], Length);
        }

        /// <summary>
        ///     Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            Return(this);
        }

        /// <summary>
        ///     Converts implicit a <see cref="PooledArray"/> instance to a <see cref="Array"/>.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static implicit operator T[](PooledArray array)
        {
            return array.Array;
        }
    }

    /// <summary>
    ///     Rents a new <see cref="PooledArray"/> instance.
    /// </summary>
    /// <param name="amount">The capacity.</param>
    /// <returns>A new <see cref="PooledArray"/> instance.</returns>
    public static PooledArray Rent(int amount)
    {
        return new PooledArray(ArrayPool<T>.Shared.Rent(amount), amount);
    }

    /// <summary>
    ///     Returns a <see cref="PooledArray"/> instance.
    /// </summary>
    /// <param name="item">The instance.</param>
    public static void Return(PooledArray item)
    {
        ArrayPool<T>.Shared.Return(item);
    }
}
