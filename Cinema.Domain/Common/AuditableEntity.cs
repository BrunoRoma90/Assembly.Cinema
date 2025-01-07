using Cinema.Domain.Interfaces;


namespace Cinema.Domain.Common;

public class AuditableEntity<Tid> : Entity<Tid> , IAuditableEntiy<int>
{
    public DateTime Created { get; set; }
    public int CreatedBy { get; set; }
    public DateTime Updated { get; set; }
    public int UpdatedBy { get; set; }
}
