using Microsoft.Data.SqlClient;
using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

namespace Assembly.Cinema.Data.Ado.Net.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            string query = "SELECT * FROM Users;";
            string cs = "";
            using SqlConnection conn = new SqlConnection(cs);
            //SqlCommand cmd = conn.CreateCommand();

            //conn.Open();
            return new List<User>();
        }

        public User Add(User user)
        {
            return user;
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public User GetWithAccount(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsernamePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User obj)
        {
            throw new NotImplementedException();
        }

        public User Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByCredencials(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public User GetUserByPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
