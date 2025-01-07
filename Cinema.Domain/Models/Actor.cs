using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Actor : AuditableEntity<int>
{       
    public Name Name { get; set; }

    public Actor(int id, Name name)
    {
        Name = name;
    }

}
