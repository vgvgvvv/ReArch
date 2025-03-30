using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using ReArch.Core.Utils;

namespace ReArch.Core;

[SkipLocalsInit]
public struct EntityData
{
	public Archetype Archetype;
	public int Index; // index in Archetype
	
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
	
	
	public void Add(int id, Archetype archetype, int index)
	{
		EntityDatas.Set(id, new EntityData(archetype, index));
	}
	
	public bool Has(int id)
	{
		return EntityDatas.TryGet(id, out EntityData _);
	}
	
	public Archetype GetArchetype(int id)
	{
	    return EntityDatas[id].Archetype;
	}
	
	public ref int GetSlot(int id)
	{
		return ref EntityDatas[id].Index;
	}
	
	public EntityData GetEntitySlot(int id)
	{
		return EntityDatas[id];
	}
	
	public void Remove(int id)
	{
		EntityDatas.Remove(id);
	}
	
	public void Move(int id, int index)
	{
		EntityDatas[id].Index = index;
	}
	
	public void Move(int id, Archetype archetype, int index)
	{
		ref var data = ref EntityDatas[id];
		data.Archetype = archetype;
		data.Index = index;
	}
	
	// TODO:public void Shift(Archetype archetype, Slot archetypeSlot, Archetype newArchetype, Slot newArchetypeSlot)
	
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