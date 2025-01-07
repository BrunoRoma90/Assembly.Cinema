using Cinema.Domain.Models;

public class CinemaRepository : Repository<Cinemas, int>, ICinemaRepository
{
    public override void Add(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public override List<Cinemas> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Cinemas GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public Cinemas GetCinemasByName(string name)
    {
        throw new NotImplementedException();
    }
}
