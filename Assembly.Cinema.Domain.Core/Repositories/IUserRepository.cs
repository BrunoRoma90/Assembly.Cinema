using Cinema.Domain.Models;

namespace Assembly.Cinema.Domain.Core.Repositories;

public interface IUserRepository : IRepository<User, int>
{
    public User GetByEmail(string email);

    public List<User> GetallByName(string name);

    public User GetWithAccount(int id);

    public User Login(string username, string password);
    public User GetUserByCredencials(string username, string password);
    public User GetUserByUsername(string username);
    public User GetUserByPassword(string password);

}