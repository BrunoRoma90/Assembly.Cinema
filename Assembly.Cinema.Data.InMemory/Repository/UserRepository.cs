using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.Data.InMemory.Repository
{
    //Sealed é criado para bloquear uma classe
    sealed class UserRepository : IUserRepository
    {

        //Override é usado para sobrescrever um método herdado da classe base que seja abstract ou virtual
        //Fornece uma nova implementação específica na classe derivada.

        private readonly Database _db;

        public UserRepository(Database database)
        {
            _db = database;
        }

        public List<User> GetAll()
        {
            return _db.Users;
        }
        public User Add(User user)
        {
            _db.Users.Add(user);
            return user;
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

        public List<User> GetallByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}