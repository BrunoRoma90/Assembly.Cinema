using System.Security.Cryptography.X509Certificates;
using Cinema.Domain.Models;

namespace Assembly.Cinema.Domain.Core.IRepository
{
    public interface IUserRepository : IRepository<User, int>
    {
        public User GetByEmail(string email);

        public List<User> GetallByName(string name);

        public User GetWithAccoount(int id);

        public User Login(string username, string password);
        public User GetUserByCredencials(string username, string password);
        public User GetUserByUsername(string username);
        public User GetUserByPassword(string password);

    }
}