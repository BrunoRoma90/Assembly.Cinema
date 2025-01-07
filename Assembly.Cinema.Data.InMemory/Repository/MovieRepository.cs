using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.Data.InMemory.Repository;

public class MovieRepository : IMovieRepository
{
    public Movie Add(Movie obj)
    {
        throw new NotImplementedException();
    }

    public Movie Delete(Movie id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetAll()
    {
        throw new NotImplementedException();
    }

    public Movie GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Movie GetMovieByName(int id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetMoviesByCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Movie Update(Movie obj)
    {
        throw new NotImplementedException();
    }
}
