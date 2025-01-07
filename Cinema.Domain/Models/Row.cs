using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Row : AuditableEntity<int>
{
    public List<Seat> Seats { get; set; }

    public Row(int id, List<Seat> seats) 
    {
        Seats = seats;
    }

}



