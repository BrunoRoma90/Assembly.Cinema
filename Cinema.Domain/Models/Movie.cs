using System.Globalization;
using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Movie : Entity
    {      
        public string Description { get; private set; }
        public string Title { get; private set; }

        public Category Category { get; private set; }

        public DateTime ReleaseDate { get; set; }

        public int DurationMinutes { get; set; }
        public List<Actor> Actors { get; private set; }

        public List<Director> Director { get; private set; }

        public int ParentalRating { get; private set; }

        public List<Review> Reviews { get; set; }


        private Movie(int id,string title): base(id) 
        {
            Title = title;
        }


        public static Movie Create(string title)
        {
            return new Movie(1, "blabla");
        }
       
        public static Movie Update(string title)
        {
            return new Movie(1, "blablabla2");
        }
    }
}
