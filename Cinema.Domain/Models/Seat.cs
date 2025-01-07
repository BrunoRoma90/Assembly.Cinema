using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Seat : Entity<int>
    {
        public int Number { get; set; }
        public bool IsAvailable { get; set; }


        private Seat(int id,int number, bool isAvailable)
        {
            Number = number;
            IsAvailable = isAvailable;
        }
    }
}
