using Assembly.Cinema.Domain.Core.IRepository;
using Cinema.Domain.Models;

public interface ITicketRepository : IRepository<Ticket, int>
{
    public Ticket GetTicketByShowTime(Showtime showtime);
    public Ticket GetTicketBySeat(Seat seat);

    public Ticket GetTicketByUser(User user);

}
