using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

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

	private World(int id, int baseChunkSize, int baseChunkEntityCount, int archetypeCapacity, int entityCapacity)
	{
		Id = id;

		// Mapping.
		GroupToArchetype = new PooledDictionary<int, Archetype>(archetypeCapacity);

		// Entity stuff.
		Archetypes = new Archetypes(archetypeCapacity);
		EntityInfo = new EntityInfoStorage(baseChunkSize, entityCapacity);
		RecycledIds = new PooledQueue<RecycledEntityGUID>(entityCapacity);

		// Query.
		QueryCache = new PooledDictionary<QueryDescription, Query>(archetypeCapacity);

		// Multithreading/Jobs.
		// JobHandles = new PooledList<JobHandle>(Environment.ProcessorCount);
		// JobsCache = new List<IJob>(Environment.ProcessorCount);

		// Config
		BaseChunkSize = baseChunkSize;
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
	public int BaseChunkSize { get; private set; } = 16_384;

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

	// TODO: internal void Move(Entity entity, Archetype source, Archetype destination, out Slot destinationSlot)
	// TODO: public void Destroy(Entity entity)
	// TODO: public void TrimExcess()
	// TODO: public void Clear()
	// TODO: public Query Query(in QueryDescription queryDescription)
	// TODO: public int CountEntities(in QueryDescription queryDescription)
	// TODO: public void GetEntities(in QueryDescription queryDescription, Span<Entity> list, int start = 0)
	// TODO: public void GetArchetypes(in QueryDescription queryDescription, Span<Archetype> archetypes, int start = 0)
	// TODO: public void GetChunks(in QueryDescription queryDescription, Span<Chunk> chunks, int start = 0)
	// TODO:  public Enumerator<Archetype> GetEnumerator()
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

		// Create archetype
		archetype = new Archetype(signature, BaseChunkSize, BaseChunkEntityCount);

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

public partial class World
{

	

}
  
#endregion

#region Batch Query Operations

public partial class World
{
	// TODO: public void Destroy(in QueryDescription queryDescription)
	// TODO: public void Set<T>(in QueryDescription queryDescription, in T? value = default)
	// TODO: public void Add<T>(in QueryDescription queryDescription, in T? component = default)
	// TODO: public void Remove<T>(in QueryDescription queryDescription)
}

#endregion

#region Accessors

public partial class World
{
	// TODO: public Archetype EnsureCapacity(in Signature signature, int amount)
	// TODO: public Archetype EnsureCapacity<T>(int amount)
	// TODO: internal void GetNextEntitiesIn(Archetype archetype, Span<Entity> entities, Span<EntityData> entityData, int amount)
	// TODO: internal void AddEntityData(Span<Entity> entities, Span<EntityData> entityData, int amount)
	// TODO: public void Create(Span<Entity> createdEntities, in Signature signature, int amount)
	// TODO: public void Create<T>(int amount, in T? cmp = default)
	// TODO: public void Set<T>(Entity entity, in T? component = default)
	// TODO: public bool Has<T>(Entity entity)
	// TODO: public ref T Get<T>(Entity entity)
	// TODO: public bool TryGet<T>(Entity entity, out T? component)
	// TODO: public ref T TryGetRef<T>(Entity entity, out bool exists)
	// TODO: public ref T AddOrGet<T>(Entity entity, T? component = default)
	// TODO: internal void Add<T>(Entity entity, out Archetype newArchetype, out Slot slot)
	// TODO: public void Add<T>(Entity entity)
	// TODO: public void Add<T>(Entity entity, in T component)
	// TODO: public void Remove<T>(Entity entity)
}

#endregion



#region Non-Generic Accessors

public partial class World
{
	// TODO: public void Set(Entity entity, object component)
	// TODO: public void SetRange(Entity entity, Span<object> components)
	// TODO: public bool Has(Entity entity, ComponentType type)
	// TODO: public bool HasRange(Entity entity, Span<ComponentType> types)
	// TODO: public object? Get(Entity entity, ComponentType type)
	// TODO: public object?[] GetRange(Entity entity, Span<ComponentType> types)
	// TODO: public void GetRange(Entity entity, Span<ComponentType> types, Span<object?> components)
	// TODO: public bool TryGet(Entity entity, ComponentType type, out object? component)
	// TODO: public void Add(Entity entity, in object cmp)
	// TODO: public void AddRange(Entity entity, Span<object> components)
	// TODO: public void AddRange(Entity entity, Span<ComponentType> components)
	// TODO: public void Remove(Entity entity, ComponentType type)
	// TODO: public void RemoveRange(Entity entity, Span<ComponentType> types)
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