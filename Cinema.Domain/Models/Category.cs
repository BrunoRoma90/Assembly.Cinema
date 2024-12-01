using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        private Category(int id ,string name): base(id)
        {
            Name = name;
        }
    }
}
