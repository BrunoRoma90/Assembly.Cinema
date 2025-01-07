﻿

namespace Cinema.Domain.Interfaces;

public interface IAuditableEntiy<TUserId>
{
    public DateTime Created { get; set; }
    public TUserId CreatedBy { get; set; }
    public DateTime Updated { get; set; }
    public TUserId UpdatedBy { get; set; }
}
