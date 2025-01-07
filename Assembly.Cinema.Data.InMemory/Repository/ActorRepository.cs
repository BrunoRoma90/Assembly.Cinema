using Cinema.Domain.Models;

public class ActorRepository : Repository<Actor, int>, IActorRepository
{
    public override void Add(Actor actor)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Actor actor)
    {
        throw new NotImplementedException();
    }

    public override List<Actor> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Actor actor)
    {
        throw new NotImplementedException();
    }

    public Actor GetActorByName(Name name)
    {
        throw new NotImplementedException();
    }
}
