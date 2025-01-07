using Cinema.Domain.Models;

public class RatingRepository : Repository<Rating, int>, IRatingRepository
{
    public override void Add(Rating obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Rating obj)
    {
        throw new NotImplementedException();
    }

    public override List<Rating> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Rating GetById(int id)
    {
        throw new NotImplementedException();
    }
    public override void Update(Rating obj)
    {
        throw new NotImplementedException();
    }
    public List<Rating> GetRatingByMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public List<Rating> GetRatingByUser(User user)
    {
        throw new NotImplementedException();
    }

 
}
