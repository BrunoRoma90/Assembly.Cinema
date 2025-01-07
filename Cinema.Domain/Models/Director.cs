using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Director : Entity<int>
    {
        public Name Name { get; set;}
        


        private Director(int id, Name name)
        {
            Name = name;
        }


    }
}
