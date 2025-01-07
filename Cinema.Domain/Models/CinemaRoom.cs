using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class CinemaRoom : AuditableEntity<int>
{
    public Cinemas Cinema { get; set; }

    public int Number {get; set;}
    public int Capacity { get; set; }


    public List<Row> Rows { get; set; }

    

    public CinemaRoom(int id, Cinemas cinema,int number,int capacity, List<Row> rows) 
    {
        Cinema = cinema;
        Number = number;
        Capacity = capacity;
        Rows = rows;
    }

}
