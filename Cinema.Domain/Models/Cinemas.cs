using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Cinemas : Entity
    {
        public string Name { get; set; }
        public string Locale { get; set; }

        public Cinemas(int id, string name, string locale) :base(id)
        {
            Name = name;
            Locale = locale;
        }
    }
}
