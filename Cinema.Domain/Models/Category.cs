using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }

        private Category(int id ,string name)
        {
            Name = name;
        }
    }
}
