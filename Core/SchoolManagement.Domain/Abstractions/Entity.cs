namespace SchoolManagement.Domain.Abstractions;
public abstract class Entity<TId> : IEquatable<Entity<TId>> where TId : notnull
{
    public TId Id { get; protected set; }

    protected Entity(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> entity && Id.Equals(entity.Id);
    }

    public bool Equals(Entity<TId>? other)
    {
        return Equals((object?)other);
    }


    public static bool operator !=(Entity<TId> left, Entity<TId> right)
    {
        return !Equals(left, right);
    }

    public static bool operator ==(Entity<TId> left, Entity<TId> right)
    {
        return Equals(left, right);
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
// : IEquatable<Entity>
//{
//    public Guid Id { get; protected init; }

//    public static bool operator ==(Entity first, Entity second)
//    {
//        if (first is null && second is null)
//        {
//            return true;
//        }

//        if (first is null || second is null)
//        {
//            return false;
//        }

//        return first.Equals(second);
//    }

//    public static bool operator !=(Entity first, Entity second)
//    {
//        return !(first == second);
//    }

//    public bool Equals(Entity other)
//    {
//        if (other is null || other.GetType() != GetType())
//        {
//            return false;
//        }

//        return other.Id == Id;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is null || obj.GetType() != GetType())
//        {
//            return false;
//        }

//        if (obj is not Entity entity)
//        {
//            return false;
//        }

//        return entity.Id == Id;
//    }

//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }
//}
