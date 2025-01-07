using Cinema.Domain.Models;

public class ShowTimeRepository : Repository<Showtime, int>, IShowTimeRepository
{
    public override void Add(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public override List<Showtime> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Showtime GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Showtime obj)
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
}
