using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Comment : AuditableEntity<int>
{      
    public string Text { get; set; }
    public User User { get; set; }
    public Movie Movie { get; set; }

    public Comment(string text, User user, Movie movie)
    {
        Text = text;
        User = user;
        Movie = movie;
    }


}
