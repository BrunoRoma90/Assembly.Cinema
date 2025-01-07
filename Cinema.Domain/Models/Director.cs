using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Director : AuditableEntity <int>
{
    public Name Name { get; set;}
    


    public Director( Name name)
    {
        Name = name;
    }


}
