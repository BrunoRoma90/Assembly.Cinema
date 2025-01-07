using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;
namespace Assembly.Cinema.Data.InMemory.Repository;
internal class TicketRepository : ITicketRepository
{
    private readonly Database _db;

    public TicketRepository(Database database)
    {
        _db = database;
    }
    public Ticket Add(Ticket obj)
    {
        throw new NotImplementedException();
    }

    public Ticket Delete(Ticket id)
    {
        throw new NotImplementedException();
    }

    public List<Ticket> GetAll()
    {
        throw new NotImplementedException();
    }

    public Ticket GetById(int id)
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

    public Ticket Update(Ticket obj)
    {
        throw new NotImplementedException();
    }
}
