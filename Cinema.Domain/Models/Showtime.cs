using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Showtime : Entity
    {
        public Movie Movie { get; set; }

        public CinemaRoom Room { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TicketPrice { get; set; }

        private Showtime(int id,Movie movie, CinemaRoom room, DateTime startTime, DateTime endTime, double ticketPrice): base(id)
        {
            Movie = movie;
            Room = room;
            StartTime = startTime;
            EndTime = endTime;
            TicketPrice = ticketPrice;
        }
    }
}
