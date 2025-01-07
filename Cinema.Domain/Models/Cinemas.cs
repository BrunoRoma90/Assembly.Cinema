using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Cinemas : AuditableEntity<int>
{
    public string Name { get; set; }
    public string Locale { get; set; }

    public Cinemas(int id, string name, string locale) 
    {
        Name = name;
        Locale = locale;
    }
}
