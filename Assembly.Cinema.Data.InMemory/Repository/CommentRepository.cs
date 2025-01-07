using Cinema.Domain.Models;

public class CommentRepository : Repository<Comment, int>, ICommentRepository
{
    public override void Add(Comment comment)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Comment comment)
    {
        throw new NotImplementedException();
    }

    public override List<Comment> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Comment GetById(int id)
    {
        throw new NotImplementedException();
    }

   
    public override void Update(Comment comment)
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


}
