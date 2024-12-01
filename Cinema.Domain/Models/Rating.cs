using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Rating : Entity
    {
        public double Value { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }

        private Rating(int id,double value, User user, Movie movie): base(id)
        {
            Value = value;
            User = user;
            Movie = movie;
        }


    }
}
