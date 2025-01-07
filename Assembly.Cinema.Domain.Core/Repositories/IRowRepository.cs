using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface IRowRepository : IRepository<Row, int>
{
    public Row GetRowBySeat(Seat seat);
}
