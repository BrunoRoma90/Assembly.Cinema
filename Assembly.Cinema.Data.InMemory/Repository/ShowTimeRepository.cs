using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.Data.InMemory.Repository;
public class ShowTimeRepository : IShowTimeRepository
{
    public Showtime Add(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public Showtime Delete(Showtime id)
    {
        throw new NotImplementedException();
    }

    public List<Showtime> GetAll()
    {
        throw new NotImplementedException();
    }

    public Showtime GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Showtime GetShowtimeByCinemaRoom(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public Showtime GetShowtimeByMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Showtime Update(Showtime obj)
    {
        throw new NotImplementedException();
    }
}
