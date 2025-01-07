using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Category : AuditableEntity<int>
{
    public string Name { get; set; }

    public Category(int id ,string name)
    {
        Name = name;
    }
}
