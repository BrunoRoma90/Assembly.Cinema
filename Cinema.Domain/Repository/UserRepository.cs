using Cinema.Domain.Models;



//Sealed é criado para bloquear uma classe
sealed class UserRepository : Repository<User, int>, IUserRepository
{

    //Override é usado para sobrescrever um método herdado da classe base que seja abstract ou virtual
    //Fornece uma nova implementação específica na classe derivada.
    public override List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public override User GetById(int id)
    {
        throw new NotImplementedException();
    }
    public override void Add(User user)
    {
        throw new NotImplementedException();
    }

    public override void Update(User user)
    {
        throw new NotImplementedException();
    }

    public override void Delete(User user)
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



