using Cinema.Domain.Models;

public class RowRepository : Repository<Row, int>, IRowRepository
{
    public override void Add(Row obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Row obj)
    {
        throw new NotImplementedException();
    }

    public override List<Row> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Row GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Row obj)
    {
        throw new NotImplementedException();
    }

    public Row GetRowBySeat(Seat seat)
    {
        throw new NotImplementedException();
    }
}
