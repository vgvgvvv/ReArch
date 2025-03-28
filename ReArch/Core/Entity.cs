using System;

namespace ReArch.Core
{
	public partial struct Entity
	{

		public readonly int Id;

		public readonly int WorldId;

		public readonly int Version;
		
	}
	
	public partial struct Entity : IEquatable<Entity>, IComparable<Entity>
	{

		public readonly static Entity Null = new(-1, 0, -1);

		/// <summary>
		///     Initializes a new instance of the <see cref="Entity"/> struct with default values.
		/// </summary>
		public Entity()
		{
			Id = -1;
			WorldId = 0;
			Version = -1;
		}
		
		internal Entity(int id, int worldId)
		{
			Id = id;
			WorldId = worldId;
			Version = 1;
		}
		
		internal Entity(int id, int worldId, int version)
		{
			Id = id;
			WorldId = worldId;
			Version = version;
		}
		
		public bool Equals(Entity other)
    {
        return ((Id ^ other.Id) | (WorldId ^ other.WorldId) | (Version ^ other.Version)) == 0;
    }


    public override bool Equals(object? obj)
    {
        return obj is Entity other && Equals(other);
    }


    public int CompareTo(Entity other)
    {
        return (WorldId.CompareTo(other.WorldId) << 16) | (Version.CompareTo(other.Version) << 8) | Id.CompareTo(other.Id);
    }


    public override int GetHashCode()
    {
        unchecked
        {
            // Overflow is fine, just wrap
            var hash = 17;
            hash = (hash * 23) + Id;
            hash = (hash * 23) + WorldId;
            hash = (hash * 23) + Version;
            return hash;
        }
    }

    public static bool operator ==(Entity left, Entity right)
    {
        return left.Equals(right);
    }


    public static bool operator !=(Entity left, Entity right)
    {
        return !left.Equals(right);
    }


    public override string ToString()
    {
        return $"Entity = {{ {nameof(Id)} = {Id}, {nameof(WorldId)} = {WorldId}, {nameof(Version)} = {Version} }}";
    }

	}
}
