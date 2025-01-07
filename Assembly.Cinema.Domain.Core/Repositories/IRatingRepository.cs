using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface IRatingRepository : IRepository<Rating, int>
{
    public List<Rating> GetRatingByUser(User user);

    public List<Rating> GetRatingByMovie(Movie movie);
}
