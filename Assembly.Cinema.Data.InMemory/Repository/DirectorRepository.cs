using Cinema.Domain.Models;

public class DirectorRepository : Repository<Director, int>, IDirectorRepository
{
    public override void Add(Director director)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Director director)
    {
        throw new NotImplementedException();
    }

    public override List<Director> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Director GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Director director)
    {
        throw new NotImplementedException();
    }

    public Director GetDirectorByName(Name name)
    {
        throw new NotImplementedException();
    }
}
