using Cinema.Domain.Models;
interface IUserRepository : IRepository<User,int>
{
   public User GetUserByCredencials(string username, string password); 
   public User GetUserByUsername(string username);
   public User GetUserByPassword(string password);

}



