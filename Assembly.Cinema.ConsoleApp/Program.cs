using Cinema.Domain.Models;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


    }


    

}

public interface IActorRepository : IRepository<Actor, int> 
{
    public Actor GetActorByName(Name name);
}
public class ActorRepository : Repository<Actor, int>, IActorRepository
{
    public override void Add(Actor actor)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Actor obj)
    {
        throw new NotImplementedException();
    }

    public override List<Actor> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Actor obj)
    {
        throw new NotImplementedException();
    }

    public Actor GetActorByName(Name name)
    {
        throw new NotImplementedException();
    }
}


public interface ICategoryRepository : IRepository<Category, int>
{
    public Category GetCategoryByName(string name);
}

public class CategoryRepository : Repository<Category, int>, ICategoryRepository
{
    public override void Add(Category category)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Category category)
    {
        throw new NotImplementedException();
    }

    public override List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Category category)
    {
        throw new NotImplementedException();
    }

    public Category GetCategoryByName(string name)
    {
        throw new NotImplementedException();
    }
}


public interface ICinemaRepository : IRepository<Cinemas, int>
{
    public Cinemas GetCinemasByName(string name);
}

public class CinemaRepository : Repository<Cinemas, int>, ICinemaRepository
{
    public override void Add(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public override List<Cinemas> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Cinemas GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Cinemas cinema)
    {
        throw new NotImplementedException();
    }

    public Cinemas GetCinemasByName(string name)
    {
        throw new NotImplementedException();
    }
}


public interface ICinemaRoomRepository : IRepository<CinemaRoom, int>
{
    public CinemaRoom GetCinemaRoomByNumber(int number);
}

public class CinemaRoomRepository : Repository<CinemaRoom, int>, ICinemaRoomRepository
{
    public override void Add(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public override void Delete(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public override List<CinemaRoom> GetAll()
    {
        throw new NotImplementedException();
    }

    public override CinemaRoom GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public CinemaRoom GetCinemaRoomByNumber(int number)
    {
        throw new NotImplementedException();
    }
}


public interface ICommentRepository : IRepository<Comment, int>
{
    public Comment GetCommentByUser(User user);

    public Comment GetCommentByMovie(Movie movie);
}

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


public interface IDirectorRepository : IRepository<Director, int>
{
    public Director GetDirectorByName(Name name);
}

public class DirectorRepository : Repository<Director, int>, IDirectorRepository
{
    public override void Add(Director director)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Director director)
    {
        throw new NotImplementedException();
    }

    public override List<Director> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Director GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Director director)
    {
        throw new NotImplementedException();
    }

    public Director GetDirectorByName(Name name)
    {
        throw new NotImplementedException();
    }
}


public interface IMovieRepository : IRepository<Movie, int>
{
    public Movie GetMovieByName(int id);
    public List<Movie> GetMoviesByCategory(Category category);
}

public class MovieRepository : Repository<Movie, int>, IMovieRepository
{
    public override void Add(Movie movie)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Movie movie)
    {
        throw new NotImplementedException();
    }

    public override List<Movie> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Movie GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Movie GetMovieByName(int id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetMoviesByCategory(Category category)
    {
        throw new NotImplementedException();
    }


}


public interface IPaymentRepository : IRepository<Payment, int>
{
    public Payment GetPaymentByUser(User user);
    public List<Payment> GetPaymentByPaymentDate(Payment paymentDate);
}

public class PaymentRepository : Repository<Payment, int>, IPaymentRepository
{
    public override void Add(Payment obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Payment obj)
    {
        throw new NotImplementedException();
    }

    public override List<Payment> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Payment GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Payment obj)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetPaymentByPaymentDate(Payment paymentDate)
    {
        throw new NotImplementedException();
    }

    public Payment GetPaymentByUser(User user)
    {
        throw new NotImplementedException();
    }



}

public interface IRatingRepository : IRepository<Rating, int>
{
    public List<Rating> GetRatingByUser(User user);

    public List<Rating> GetRatingByMovie(Movie movie);
}

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

public interface IReviewRepository : IRepository<Review, int>
{
    public Review GetReviewByUser(User user);
    public Review GetReviewByMovie(Movie movie);
}

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

public interface IRowRepository : IRepository<Row, int>
{
    public Row GetRowBySeat(Seat seat);
}

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

public interface IShowTimeRepository : IRepository<Showtime, int>
{
    public Showtime GetShowtimeByMovie(Movie movie);

    public Showtime GetShowtimeByCinemaRoom(CinemaRoom cinemaRoom);
}

public class ShowTimeRepository : Repository<Showtime, int>, IShowTimeRepository
{
    public override void Add(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public override List<Showtime> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Showtime GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Showtime obj)
    {
        throw new NotImplementedException();
    }

    public Showtime GetShowtimeByCinemaRoom(CinemaRoom cinemaRoom)
    {
        throw new NotImplementedException();
    }

    public Showtime GetShowtimeByMovie(Movie movie)
    {
        throw new NotImplementedException();
    }
}

public interface ITicketRepository : IRepository<Ticket, int>
{
    public Ticket GetTicketByShowTime(Showtime showtime);
    public Ticket GetTicketBySeat(Seat seat);

    public Ticket GetTicketByUser(User user);

}
public class TicketRepository : Repository<Ticket, int>, ITicketRepository
{
    public override void Add(Ticket obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Ticket obj)
    {
        throw new NotImplementedException();
    }

    public override List<Ticket> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Ticket GetById(int id)
    {
        throw new NotImplementedException();
    }
    public override void Update(Ticket obj)
    {
        throw new NotImplementedException();
    }
    public Ticket GetTicketBySeat(Seat seat)
    {
        throw new NotImplementedException();
    }

    public Ticket GetTicketByShowTime(Showtime showtime)
    {
        throw new NotImplementedException();
    }

    public Ticket GetTicketByUser(User user)
    {
        throw new NotImplementedException();
    }

   
}
