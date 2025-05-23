namespace SharedKernel.Domain;

public abstract class Entity<TId>(TId id) : IEquatable<Entity<TId>>, IAggregateRoot
    where TId : notnull
{
    private TId Id { get; } = id;

    public bool Equals(Entity<TId>? other)
    {
        return Equals(other as object);
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> entity && Id.Equals(entity.Id);
    }

    public static bool operator ==(Entity<TId>? a, Entity<TId>? b)
    {
        return Equals(a, b);
    }

    public static bool operator !=(Entity<TId>? a, Entity<TId>? b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}