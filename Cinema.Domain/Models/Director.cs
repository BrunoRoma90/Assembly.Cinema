using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Director : Entity
    {
        public Name Name { get; set;}
        


        private Director(int id, Name name): base(id) 
        {
            Name = name;
        }


    }
}
