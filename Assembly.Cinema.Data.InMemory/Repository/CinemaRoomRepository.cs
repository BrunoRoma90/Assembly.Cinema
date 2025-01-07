using Cinema.Domain.Models;

public class CinemaRoomRepository : Repository<CinemaRoom, int>, ICinemaRoomRepository
{
    public override void Add(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public override void Delete(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public override List<CinemaRoom> GetAll()
    {
        throw new NotImplementedException();
    }

    public override CinemaRoom GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public CinemaRoom GetCinemaRoomByNumber(int number)
    {
        throw new NotImplementedException();
    }
}
