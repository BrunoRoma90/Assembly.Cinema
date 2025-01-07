using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.Data.InMemory.Repository;

public class CommentRepository : ICommentRepository
{
    public Comment Add(Comment obj)
    {
        throw new NotImplementedException();
    }

    public Comment Delete(Comment id)
    {
        throw new NotImplementedException();
    }

    public List<Comment> GetAll()
    {
        throw new NotImplementedException();
    }

    public Comment GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Comment GetCommentByMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Comment GetCommentByUser(User user)
    {
        throw new NotImplementedException();
    }

    public Comment Update(Comment obj)
    {
        throw new NotImplementedException();
    }
}
