using Cinema.Domain.Common;
using Cinema.Domain.Models;

public class Row : Entity<int>
{
    public List<Seat> Seats { get; set; }

    private Row(int id, List<Seat> seats) 
    {
        Seats = seats;
    }

}



