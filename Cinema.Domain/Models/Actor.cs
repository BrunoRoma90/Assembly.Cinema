using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Actor : Entity
    {       
        public Name Name { get; set; }

        private Actor(int id, Name name) : base(id)
        {
            Name = name;
        }

    }
}
