using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface IDirectorRepository : IRepository<Director, int>
{
    public Director GetDirectorByName(Name name);
}
