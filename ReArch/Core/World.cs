using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Arch.Core;

using Collections.Pooled;

using ReArch.Core.Utils;

namespace ReArch.Core;

#region Static Create and Destroy
public partial class World
{
	public static World[] Worlds { get; private set; } = new World[4];
	private static PooledQueue<int> RecycledWorldIds = new(8);
	public static int WorldSize { get; private set; }

	public static World Create(int chunkSizeInBytes = 16_384, int minimumAmountOfEntitiesPerChunk = 100, int archetypeCapacity = 2, int entityCapacity = 64)
	{
		lock (Worlds)
		{
			var recycle = RecycledWorldIds.TryDequeue(out var id);
			var recycledId = recycle ? id : WorldSize;
				
			var world = new World(chunkSizeInBytes, minimumAmountOfEntitiesPerChunk, archetypeCapacity, entityCapacity, recycledId);
				
			if (recycledId >= Worlds.Length)
			{
				var newCapacity = Worlds.Length * 2;
				var worlds = Worlds;
				Array.Resize(ref worlds, newCapacity);
				Worlds = worlds;
			}
				
			Worlds[recycledId] = world;
			WorldSize++;
			return world;
		}
			
	}

	public static void Destroy(World world)
	{
		world.Capacity = 0;
		world.Size = 0;

		// Dispose
		// world.JobHandles.Dispose();
		world.GroupToArchetype.Dispose();
		world.RecycledIds.Dispose();
		world.QueryCache.Dispose();

		// Set archetypes to null to free them manually since Archetypes are set to ClearMode.Never to fix #65
		for (var index = 0; index < world.Archetypes.Count; index++)
		{
			world.Archetypes[index] = null!;
		}

		world.Archetypes.Dispose();
	}

}
#endregion

#region World Management

public partial class World : IDisposable
{

	private World(int id, int baseEntityChunkSize, int baseChunkEntityCount, int archetypeCapacity, int entityCapacity)
	{
		Id = id;

		// Mapping.
		GroupToArchetype = new PooledDictionary<int, Archetype>(archetypeCapacity);

		// Entity stuff.
		Archetypes = new Archetypes(archetypeCapacity);
		EntityInfo = new EntityInfoStorage(baseEntityChunkSize, entityCapacity);
		RecycledIds = new PooledQueue<RecycledEntityGUID>(entityCapacity);

		// Query.
		QueryCache = new PooledDictionary<QueryDescription, Query>(archetypeCapacity);

		// Multithreading/Jobs.
		// JobHandles = new PooledList<JobHandle>(Environment.ProcessorCount);
		// JobsCache = new List<IJob>(Environment.ProcessorCount);

		// Config
		BaseEntityChunkSize = baseEntityChunkSize;
		BaseChunkEntityCount = baseChunkEntityCount;
	}
	/// <summary>
	///     The unique <see cref="World"/> ID.
	/// </summary>
	public int Id {  get; }

	/// <summary>
	///     The amount of <see cref="Entity"/>s currently stored by this <see cref="World"/>.
	/// </summary>
	public int Size {  get; internal set; }

	/// <summary>
	///     The available <see cref="Entity"/> capacity of this <see cref="World"/>.
	/// </summary>
	public int Capacity {  get; internal set; }

	/// <summary>
	///     All <see cref="Archetype"/>s that exist in this <see cref="World"/>.
	/// </summary>
	public Archetypes Archetypes {  get; }

	/// <summary>
	///     Maps an <see cref="Entity"/> to its <see cref="EntityInfo"/> for quick lookup.
	/// </summary>
	internal EntityInfoStorage EntityInfo {  get; }

	/// <summary>
	///     Stores recycled <see cref="Entity"/> IDs and their last version.
	/// </summary>
	internal PooledQueue<RecycledEntityGUID> RecycledIds {  get; set; }

	/// <summary>
	///     A cache to map <see cref="QueryDescription"/> to their <see cref="Core.Query"/>, to avoid allocs.
	/// </summary>
	internal PooledDictionary<QueryDescription, Query> QueryCache {  get; set; }

	/// <summary>
	///     The <see cref="Chunk"/> size of each <see cref="Archetype"/> in bytes.
	/// <remarks>For the best cache optimisation use values that are divisible by 16Kb.</remarks>
	/// </summary>
	public int BaseEntityChunkSize { get; private set; } = 4096;

	/// <summary>
	///     The minimum number of <see cref="Entity"/>'s that should fit into a <see cref="Chunk"/> within all <see cref="Archetype"/>s.
	///     On the basis of this, the <see cref="Archetypes"/>s chunk size may increase.
	/// </summary>
	public int BaseChunkEntityCount { get; private set; } = 100;

	
	[StructuralChange]
	public void Dispose()
	{
		Destroy(this);
		// In case the user (or us) decides to override and provide a finalizer, prevents them from having
		// to re-implement Dispose() to avoid calling it twice.
		GC.SuppressFinalize(this);
	}
}

#endregion

#region Entities

public partial class World
{
	private void GetOrCreateNextEntity(out Entity entity)
	{
		var recycle = RecycledIds.TryDequeue(out var recycledId);
		var recycled = recycle ? recycledId : new RecycledEntityGUID(Size, 1);
		entity = new Entity(recycled.Id, Id, recycled.Version);
		Size++;
	}
	
	private void DestroyEntity(Entity entity)
	{
		var recycledEntity = new RecycledEntityGUID(entity.Id, unchecked(entity.Version + 1));
		RecycledIds.Enqueue(recycledEntity);
		EntityInfo.Remove(entity.Id);
		Size--;
	}
	
	[StructuralChange]
	public Entity Create(params ComponentType[] types)
	{
		return Create(new Signature(types));
	}
	
	[StructuralChange]
	public Entity Create(in Signature types)
	{
		// Create new entity and put it to the back of the array
		GetOrCreateNextEntity(out var entity);

		// Add to archetype & mapping
		var archetype = GetOrCreateArchetype(in types);
		var allocatedEntities = archetype.Add(entity, out var index);

		// Resize map & Array to fit all potential new entities
		Capacity += allocatedEntities;
		EntityInfo.EnsureCapacity(Capacity);

		// Add entity to info storage
		EntityInfo.Add(entity.Id, archetype, index);

		return entity;
	}

	internal void Move(Entity entity, Archetype source, Archetype destination, out int destinationIndex)
	{
#if DEBUG
		Debug.Assert(source != destination, "From-Archetype is the same as the To-Archetype. Entities cannot move within the same archetype using this function. Probably an attempt was made to attach already existing components to the entity or to remove non-existing ones.");
#endif
		int index = EntityInfo.GetSlot(entity.Id);
		var allocatedEntities = destination.Add(entity, out destinationIndex);
		source.Remove(index, out var movedEntityId);

		// movedEntityId can be -1, will overwrite by next move invoke
		EntityInfo.Move(movedEntityId, index);
		EntityInfo.Move(entity.Id, destination, destinationIndex);
		
		Capacity += allocatedEntities;
		EntityInfo.EnsureCapacity(Capacity);
	}

	public void Destroy(Entity entity)
	{
		// Remove from archetype and move other entity to replace its slot
		var entityInfo = EntityInfo[entity.Id];
		entityInfo.Archetype.Remove(entityInfo.Index, out var movedEntityId);
		EntityInfo.Move(movedEntityId, entityInfo.Index);

		DestroyEntity(entity);
	}

	public void TrimExcess()
	{
		Capacity = 0;

		// Trim entity info and archetypes
		EntityInfo.TrimExcess();
		for (var index = Archetypes.Count - 1; index >= 0; index--)
		{
			// Remove empty archetypes.
			var archetype = Archetypes[index];
			if (archetype.EntityCount == 0)
			{
				Capacity += archetype.EntitiesPerChunk; // Since the destruction substracts that amount, add it before due to the way we calculate the new capacity.
				DestroyArchetype(archetype);
				continue;
			}

			archetype.TrimExcess();
			Capacity += archetype.Entities.Capacity;
		}

		// Traverse recycled ids and remove all that are higher than the current capacity.
		// If we do not do this, a new entity might get a id higher than the entityinfo array which causes it to go out of bounds.
		RecycledIds.RemoveWhere(entity => entity.Id >= Capacity);
	}

	public void Clear()
	{
		Capacity = 0;
		Size = 0;

		// Clear
		RecycledIds.Clear();
		GroupToArchetype.Clear();
		EntityInfo.Clear();
		QueryCache.Clear();

		// Set archetypes to null to free them manually since Archetypes are set to ClearMode.Never to fix #65
		for (var index = 0; index < Archetypes.Count; index++)
		{
			Archetypes[index].Clear();
			Archetypes[index] = null!;
		}

		Archetypes.Clear();
	}

	public Query Query(in QueryDescription queryDescription)
	{
		// Looping over all archetypes, their chunks and their entities.
		var queryCache = QueryCache; // Storing locally to only access the QueryCache once
		if (queryCache.TryGetValue(queryDescription, out var query))
		{
			return query;
		}

		query = new Query(Archetypes, queryDescription);
		queryCache[queryDescription] = query;

		return query;
	}

	public int CountEntities(in QueryDescription queryDescription)
	{
		int count = 0;
		var query = Query(queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				count++;
			}
		}

		return count;
	}

	public void GetEntities(in QueryDescription queryDescription, Span<Entity> list, int start = 0)
	{
		var index = 0;
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				list[start + index] = entity;
				index++;
			}
		}
	}

	public void GetArchetypes(in QueryDescription queryDescription, Span<Archetype> archetypes, int start = 0)
	{
		var index = 0;
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			archetypes[start + index] = archetype;
			index++;
		}
	}

	public Enumerator<Archetype> GetEnumerator()
	{
		return new Enumerator<Archetype>(Archetypes.AsSpan());
	}
}

#endregion

#region Archetypes

public partial class World
{

	/// <summary>
	///     Maps a <see cref="Components"/> hash to its <see cref="Archetype"/>.
	/// </summary>
	internal PooledDictionary<int, Archetype> GroupToArchetype {  get; set; }
	
	
	internal Archetype GetOrCreateArchetype(in Signature signature)
	{
		var hashCode = signature.GetHashCode();
		if (TryGetArchetype(hashCode, out var archetype))
		{
			return archetype;
		}

		var initialChunkCount = BaseChunkEntityCount / BaseEntityChunkSize;
		var entityCountPerChunk = BaseEntityChunkSize / Unsafe.SizeOf<Entity>();
		
		// Create archetype
		archetype = new Archetype(signature, entityCountPerChunk, initialChunkCount);

		GroupToArchetype[hashCode] = archetype;
		Archetypes.Add(archetype);

		// Archetypes always allocate one single chunk upon construction
		Capacity += archetype.EntitiesPerChunk;
		EntityInfo.EnsureCapacity(Capacity);

		return archetype;
	}
	
	[Pure]
	internal bool TryGetArchetype(int hash, [MaybeNullWhen(false)] out Archetype archetype)
	{
		return GroupToArchetype.TryGetValue(hash, out archetype);
	}
	
	[Pure]
    public bool TryGetArchetype(in Signature signature, [MaybeNullWhen(false)] out Archetype archetype)
    {
        return TryGetArchetype(signature.GetHashCode(), out archetype);
    }
    
	internal void DestroyArchetype(Archetype archetype)
	{
		var hash = Component.GetHashCode(archetype.Signature);
		Archetypes.Remove(archetype);
		GroupToArchetype.Remove(hash);

		archetype.Clear();
		Capacity -= archetype.EntitiesPerChunk;
	}

}

#endregion
  
#region Queries

public interface IForEach
{
	public void Update(Entity entity);
}

public delegate void ForEach(Entity entity);

public partial class World
{

	public void Query(in QueryDescription queryDescription, ForEach forEntity)
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				forEntity(entity);
			}
		}
	}
	
	public void InlineQuery<T>(in QueryDescription queryDescription) where T : struct, IForEach
	{
		var t = new T();

		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				t.Update(entity);
			}
		}
	}
	
	public void InlineQuery<T>(in QueryDescription queryDescription, ref T iForEach) where T : struct, IForEach
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				iForEach.Update(entity);
			}
		}
	}

}
  
#endregion

#region Batch Query Operations

public partial class World
{
	[StructuralChange]
	public void Destroy(in QueryDescription queryDescription)
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (var entity in archetype.Entities)
			{
				DestroyEntity(entity);
			}
			archetype.Clear();
		}
	}

	public void Set<T>(in QueryDescription queryDescription, in T value = default) where T : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			foreach (ref var component in archetype.GetComponents<T>())
			{
				component = value;
			}
		}
	}

	[SkipLocalsInit]
    [StructuralChange]
	public void Add<T>(in QueryDescription queryDescription, in T component = default) where T : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			if (archetype.EntityCount == 0 || archetype.Has<T>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var count = oldArchetype.EntityCount;
			var newSignature = Signature.Add(archetype.Signature, Component<T>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			newArchetype.SetRange(newArchetypeIndex, count, component);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}
	}

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T>(in QueryDescription queryDescription) where T : unmanaged
	{
		var query = Query(in queryDescription);
		foreach (var archetype in query.GetArchetypeIterator())
		{
			// Archetype without T shouldnt be skipped to prevent undefined behaviour.
			if (archetype.EntityCount <= 0 || !archetype.Has<T>())
			{
				continue;
			}
			
			var oldArchetype = archetype;
			var newSignature = Signature.Add(archetype.Signature, Component<T>.Signature);
			// create new archetype
			var newArchetype = GetOrCreateArchetype(newSignature);
			var newArchetypeIndex = newArchetype.EntityCount;
			// move entityinfo to new archetype
			EntityInfo.MoveToAnotherArchetype(oldArchetype, newArchetype, newArchetypeIndex);
			
			var oldCapacity = oldArchetype.EntityCapacity;
			// copy entity & component after new archetype
			Archetype.CopyAfter(oldArchetype, newArchetype);
			// clear old archetype
			oldArchetype.Clear();
			
			// Update capacity
			Capacity += newArchetype.EntityCapacity - oldCapacity;
		}
	}
}

#endregion

#region Accessors

public partial class World
{
	public Archetype EnsureCapacity(in Signature signature, int amount)
	{
		// Ensure size of archetype
		var archetype = GetOrCreateArchetype(signature);
		Capacity -= archetype.EntityCapacity;     // Reduce capacity, in case the previous capacity was already included, ensures more and more till memory leak
		archetype.Entities.EnsureCapacity(archetype.EntityCount + amount);

		// Ensure size of world
		var requiredCapacity = Capacity + archetype.EntityCapacity;
		EntityInfo.EnsureCapacity(requiredCapacity);
		Capacity = requiredCapacity;

		return archetype;
	}

	public Archetype EnsureCapacity<T>(int amount)
	{
		return EnsureCapacity(in Component<T>.Signature, amount);
	}

	internal void GetNextEntitiesIn(Archetype archetype, Span<Entity> entities, Span<EntityData> entityData, int amount)
	{
		var startIndex = archetype.Entities.Count;
		for(var index = 0; index < amount; index++)
		{
			GetOrCreateNextEntity(out var entity);
			entities[index] = entity;
			entityData[index] = new EntityData(archetype, startIndex + index);
		}
	}

	internal void AddEntityData(Span<Entity> entities, Span<EntityData> entityData, int amount)
	{
		var existingEntityData = EntityInfo.EntityDatas;
		for (var index = 0; index < amount; index++)
		{
			var entity = entities[index];
			ref var data = ref entityData[index];
			existingEntityData.Set(entity.Id, in data);
		}
	}

	public void Create(Span<Entity> createdEntities, in Signature signature, int amount)
	{
		var archetype = EnsureCapacity(in signature, amount);

		// Rent arrays
		using var entityDataArray = Pool<EntityData>.Rent(amount);
		var entityData = entityDataArray.AsSpan();

		// Create entities
		GetNextEntitiesIn(archetype, createdEntities, entityData, amount);
		archetype.AddAll(createdEntities, amount);

		// Add entities to entityinfo
		AddEntityData(createdEntities, entityData, amount);
	}
	
	public void Create<T>(int amount, in T cmp = default) where T : unmanaged
	{
		var archetype = EnsureCapacity<T>(amount);

		// Prepare entities, slots and data
		using var entityArray =  Pool<Entity>.Rent(amount);
		using var entityDataArray =  Pool<EntityData>.Rent(amount);
		var entities = entityArray.AsSpan();
		var entityData = entityDataArray.AsSpan();

		// Create entities
		GetNextEntitiesIn(archetype, entities, entityData, amount);
		archetype.AddAll(entities, amount);

		// Fill entities
		var firstSlot = entityData[0].Index;
		var lastSlot = entityData[amount - 1].Index;
		var count = lastSlot - firstSlot;
		archetype.SetRange(in firstSlot, in count, cmp);

		// Add entities to entityinfo
		AddEntityData(entities, entityData, amount);
	}
	
	public void Set<T>(Entity entity, in T component = default) where T : unmanaged
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		var index = entitySlot.Index;
		var archetype = entitySlot.Archetype;
		archetype.Set(ref index, in component);
	}
	
	public bool Has<T>(Entity entity) where T : unmanaged
	{
		var archetype = EntityInfo.GetArchetype(entity.Id);
		return archetype.Has<T>();
	}

	public ref T Get<T>(Entity entity) where T : unmanaged
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		var index = entitySlot.Index;
		var archetype = entitySlot.Archetype;
		return ref archetype.Get<T>(ref index);
	}

	public bool TryGet<T>(Entity entity, out T? component) where T : unmanaged
	{
		component = default;

		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		var index = entitySlot.Index;
		var archetype = entitySlot.Archetype;

		if (!archetype.Has<T>())
		{
			return false;
		}

		component = archetype.Get<T>(ref index);
		return true;
	}
	
	public ref T TryGetRef<T>(Entity entity, out bool exists) where T : unmanaged
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		var index = entitySlot.Index;
		var archetype = entitySlot.Archetype;

		if (!(exists = archetype.Has<T>()))
		{
			return ref Unsafe.NullRef<T>();
		}

		return ref archetype.Get<T>(ref index);
	}
	
	public ref T AddOrGet<T>(Entity entity, T component = default) where T : unmanaged
	{
		ref T cmp = ref TryGetRef<T>(entity, out var exists);
		if (exists)
		{
			return ref cmp;
		}

		Add(entity, component);
		return ref Get<T>(entity);
	}
	
	[StructuralChange]
	internal void Add<T>(Entity entity, out Archetype newArchetype, out int addedIndex)  where T : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var type = Component<T>.ComponentType;
		var newSignature = Signature.Add(oldArchetype.Signature, type);
		newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out addedIndex);
	}
	
	[SkipLocalsInit]
	[StructuralChange]
	public void Add<T>(Entity entity) where T : unmanaged
	{
		Add<T>(entity, out _, out _);
	}
	
	public void Add<T>(Entity entity, in T component) where T : unmanaged
	{
		Add<T>(entity, out var newArchetype, out var slot);
		newArchetype.Set(ref slot, component);
	}
	
	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T>(Entity entity)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var type = Component<T>.ComponentType;
		var newSignature = Signature.Remove(oldArchetype.Signature, type);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}
}

#endregion



#region Non-Generic Accessors

public partial class World
{
	public void Set(Entity entity, object component)
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		entitySlot.Archetype.Set(ref entitySlot.Index, component);
		
	}

	public void SetRange(Entity entity, Span<object> components)
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		foreach (var cmp in components)
		{
			entitySlot.Archetype.Set(ref entitySlot.Index, cmp);
		}
	}

	public bool Has(Entity entity, ComponentType type)
	{
		var archetype = EntityInfo.GetArchetype(entity.Id);
		return archetype.Has(type);
	}

	public bool HasRange(Entity entity, Span<ComponentType> types)
	{
		var archetype = EntityInfo.GetArchetype(entity.Id);
		foreach (var type in types)
		{
			if (!archetype.Has(type))
			{
				return false;
			}
		}

		return true;
	}

	public object? Get(Entity entity, ComponentType type)
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		return entitySlot.Archetype.Get(entitySlot.Index, type);
	}

	public object?[] GetRange(Entity entity, Span<ComponentType> types)
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		var array = new object?[types.Length];
		for (var index = 0; index < types.Length; index++)
		{
			var type = types[index];
			array[index] = entitySlot.Archetype.Get(entitySlot.Index, type);
		}

		return array;
	}

	public void GetRange(Entity entity, Span<ComponentType> types, Span<object?> components)
	{
		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		for (var index = 0; index < types.Length; index++)
		{
			var type = types[index];
			components[index] = entitySlot.Archetype.Get(entitySlot.Index, type);
		}
	}

	public bool TryGet(Entity entity, ComponentType type, out object? component)
	{
		component = default;
		if (!Has(entity, type))
		{
			return false;
		}

		var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
		component = entitySlot.Archetype.Get(entitySlot.Index, type);
		return true;
	}

	public void Add(Entity entity, in object cmp)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var type = (ComponentType)cmp.GetType();
		var newSignature = Signature.Add(oldArchetype.Signature, type);
		var newArchetype = GetOrCreateArchetype(newSignature);

		Move(entity, oldArchetype, newArchetype, out var index);
		newArchetype.Set(ref index, cmp);
	}
	
	public unsafe int AddRange(Entity entity, Span<object> components)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var oldSignature = oldArchetype.Signature;
		Slice<ComponentType> types = stackalloc ComponentType[components.Length];
		int tmpIndex = 0;
		foreach (object component in components)
		{
			var type = component.GetType();
			if (!ComponentRegistry.TryGet(type, out var componentType))
			{
				throw new Exception($"type {type} is not a registered component type");
			}
			types[tmpIndex] = componentType;
			tmpIndex++;
		}
		Signature newSignature = Signature.AddRange(oldSignature, types);

		var newArchetype = GetOrCreateArchetype(newSignature);
		Move(entity, oldArchetype, newArchetype, out var index);
		
		foreach (var cmp in components)
		{
			newArchetype.Set(ref index, cmp);
		}

		return index;
	}

	public int AddRange(Entity entity, Slice<ComponentType> componentTypes)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var oldSignature = oldArchetype.Signature;
		Signature newSignature = Signature.AddRange(oldSignature, componentTypes);

		var newArchetype = GetOrCreateArchetype(newSignature);
		Move(entity, oldArchetype, newArchetype, out var index);

		return index;
	}
	
	public void Remove(Entity entity, ComponentType type)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var newSignature = Signature.Remove(oldArchetype.Signature, type);
		var newArchetype = GetOrCreateArchetype(newSignature);

		Move(entity, oldArchetype, newArchetype, out var index);
	}

	public int RemoveRange(Entity entity, Span<ComponentType> componentTypes)
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var oldSignature = oldArchetype.Signature;
		
		Signature newSignature = Signature.RemoveRange(oldSignature, componentTypes);
		
		var newArchetype = GetOrCreateArchetype(newSignature);
		Move(entity, oldArchetype, newArchetype, out var index);

		return index;
	}
}

#endregion

#region Utility

public partial class World
{
	[Pure]
	public bool IsAlive(Entity entity)
	{
		return entity.Version > 0 && EntityInfo.Has(entity.Id);
	}

	public Archetype GetArchetype(Entity entity)
	{
		return EntityInfo.GetArchetype(entity.Id);
	}

	public ComponentType[] GetComponentTypes(Entity entity)
	{
		var archetype = EntityInfo.GetArchetype(entity.Id);
		return archetype.Signature;
	}

	public unsafe object?[] GetAllComponents(Entity entity)
	{
		// Get archetype and chunk.
        var entitySlot = EntityInfo.GetEntitySlot(entity.Id);
        var archetype = entitySlot.Archetype;

        // Loop over components, collect and returns them.
        var cmps = new object?[archetype.Components.Length];

        for (var index = 0; index < archetype.Components.Length; index++)
        {
            var componentArray = archetype.Components[index];
            var component = componentArray.GetObject(entitySlot.Index);
            cmps[index] = component;
        }

        return cmps;
	}
}

#endregion