using System;
using System.Collections.Generic;
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

		// Remove archetype from other archetypes edges.
		// foreach (var otherArchetype in this)
		// {
		// 	otherArchetype.RemoveEdge(archetype);
		// }

		archetype.Clear();
		Capacity -= archetype.EntitiesPerChunk;
	}

}

  #endregion