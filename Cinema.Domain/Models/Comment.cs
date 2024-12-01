using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Comment : Entity
    {      
        public string Text { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }

        private Comment(int id,string text, User user, Movie movie): base(id)
        {
            Text = text;
            User = user;
            Movie = movie;
        }


    }
}
