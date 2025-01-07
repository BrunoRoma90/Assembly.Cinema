using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Actor : Entity<int>
    {       
        public Name Name { get; set; }

        private Actor(int id, Name name)
        {
            Name = name;
        }

    }
}
