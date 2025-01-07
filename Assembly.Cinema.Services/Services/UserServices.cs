using Assembly.Cinema.Domain.Core.IRepository;
using Assembly.Cinema.Services.Interfaces;
using Cinema.Domain.Models;

namespace Assembly.Cinema.Services.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User Add(User user)
        {
            return _userRepository.Add(user);
        }
    }
}
