using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using ReArch.Core.Utils;

namespace ReArch.Core;

[SkipLocalsInit]
public struct EntityData
{
	public Archetype Archetype;
	public int Index;
	
	public EntityData(Archetype archetype, int index)
	{
		Archetype = archetype;
		Index = index;
	}
}

internal class EntityInfoStorage
{
	internal JaggedArray<EntityData> EntityDatas { get; set; }

	internal EntityInfoStorage(int baseChunkSize, int capacity)
	{
		EntityDatas = new JaggedArray<EntityData>(
			baseChunkSize / Unsafe.SizeOf<EntityData>(), 
			capacity, 
			new EntityData(null, -1));
	}
	
	// TODO:
	// Add Has
	
	public void EnsureCapacity(int capacity)
	{
		EntityDatas.EnsureCapacity(capacity);
	}
	
	public void Clear()
	{
		EntityDatas.Clear();
	}
	
	internal ref EntityData this[int id]
	{
		get
		{
			return ref EntityDatas[id];
		}
	}
}