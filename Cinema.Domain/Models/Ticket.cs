using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Ticket : AuditableEntity<int>
{
    public Showtime Showtime { get; set; }

    public Seat Seat { get; set; }

    public User User { get; set; }

    public DateTime PurchaseDate { get; set; }

    public double PricePaid { get; set; }

    public Ticket(Showtime showtime, Seat seat, User user, DateTime purchaseDate, double pricePaid)
    {
        Showtime = showtime;
        Seat = seat;
        User = user;
        PurchaseDate = purchaseDate;
        PricePaid = pricePaid;
    }


}
