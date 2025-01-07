using Cinema.Domain.Models;

public class TicketRepository : Repository<Ticket, int>, ITicketRepository
{
    public override void Add(Ticket obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Ticket obj)
    {
        throw new NotImplementedException();
    }

    public override List<Ticket> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Ticket GetById(int id)
    {
        throw new NotImplementedException();
    }
    public override void Update(Ticket obj)
    {
        throw new NotImplementedException();
    }
    public Ticket GetTicketBySeat(Seat seat)
    {
        throw new NotImplementedException();
    }

    public Ticket GetTicketByShowTime(Showtime showtime)
    {
        throw new NotImplementedException();
    }

    public Ticket GetTicketByUser(User user)
    {
        throw new NotImplementedException();
    }

   
}
