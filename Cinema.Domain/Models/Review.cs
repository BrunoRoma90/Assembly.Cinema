using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Review : AuditableEntity<int>
{
    public User User { get; set; }
    public Movie Movie { get; set; }

    public Rating Rating { get; set; }
    public Comment Comment { get; set; }

    public DateTime ReviewDate { get; set; }

    private Review( User user, Movie movie, Rating rating, Comment comment, DateTime reviewDate)
    {
        User = user;
        Movie = movie;
        Rating = rating;
        Comment = comment;
        ReviewDate = reviewDate;
    }
}
