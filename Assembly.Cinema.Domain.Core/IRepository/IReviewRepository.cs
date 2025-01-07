using Assembly.Cinema.Domain.Core.IRepository;
using Cinema.Domain.Models;

public interface IReviewRepository : IRepository<Review, int>
{
    public Review GetReviewByUser(User user);
    public Review GetReviewByMovie(Movie movie);
}
