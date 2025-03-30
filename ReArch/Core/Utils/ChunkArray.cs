using System;
using System.Runtime.InteropServices;

namespace ReArch.Core.Utils;

internal struct Slot
{
	int IndexOfChunk;
	int IndexInChunk;
};

internal unsafe struct Chunk
{
	int ItemSize;
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

public class ChunkArray<T> : IDisposable
{


	public void Dispose()
	{
		
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