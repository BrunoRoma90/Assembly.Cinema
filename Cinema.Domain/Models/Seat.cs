using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Seat : AuditableEntity<int>
{
    public int Number { get; set; }
    public bool IsAvailable { get; set; }


    public Seat(int number, bool isAvailable)
    {
        Number = number;
        IsAvailable = isAvailable;
    }
}
