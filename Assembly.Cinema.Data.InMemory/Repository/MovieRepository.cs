using Cinema.Domain.Models;

public class MovieRepository : Repository<Movie, int>, IMovieRepository
{
    public override void Add(Movie movie)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Movie movie)
    {
        throw new NotImplementedException();
    }

    public override List<Movie> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Movie GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Movie movie)
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


}
