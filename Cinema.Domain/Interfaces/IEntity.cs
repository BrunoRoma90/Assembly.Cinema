namespace Cinema.Domain.Interfaces;

public interface IEntity<TId>
{
    public TId Id { get; }
}
public interface ISoftDeletable
{
    public bool IsDeleted { get; set; }
}
