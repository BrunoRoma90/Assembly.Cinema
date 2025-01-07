using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface ICinemaRepository : IRepository<Cinemas, int>
{
    public Cinemas GetCinemasByName(string name);
}
