using Cinema.Domain.Interfaces;


namespace Cinema.Domain.Common;

public class Entity<TId> : IEntity<TId>
{
    public TId Id { get; private set; } = default;
}
