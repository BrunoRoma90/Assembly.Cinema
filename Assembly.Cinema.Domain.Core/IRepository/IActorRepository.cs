using Assembly.Cinema.Domain.Core.IRepository;
using Cinema.Domain.Models;

public interface IActorRepository : IRepository<Actor, int> 
{
    public Actor GetActorByName(Name name);
}
