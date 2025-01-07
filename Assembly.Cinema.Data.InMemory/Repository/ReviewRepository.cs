using Cinema.Domain.Models;

public class ReviewRepository : Repository<Review, int>, IReviewRepository
{
    public override void Add(Review obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Review obj)
    {
        throw new NotImplementedException();
    }

    public override List<Review> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Review GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Review obj)
    {
        throw new NotImplementedException();
    }
    public Review GetReviewByMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Review GetReviewByUser(User user)
    {
        throw new NotImplementedException();
    }
}
