using Assembly.Cinema.Domain.Core.IRepository;
using Cinema.Domain.Models;

public interface IMovieRepository : IRepository<Movie, int>
{
    public Movie GetMovieByName(int id);
    public List<Movie> GetMoviesByCategory(Category category);
}
