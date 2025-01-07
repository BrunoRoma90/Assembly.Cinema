using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Rating : Entity<int>
    {
        public double Value { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }

        private Rating(int id,double value, User user, Movie movie)
        {
            Value = value;
            User = user;
            Movie = movie;
        }


    }
}
