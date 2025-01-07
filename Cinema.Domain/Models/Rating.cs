using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Rating : AuditableEntity<int>
{
    public double Value { get; set; }
    public User User { get; set; }
    public Movie Movie { get; set; }

    public Rating(double value, User user, Movie movie)
    {
        Value = value;
        User = user;
        Movie = movie;
    }


}
