

using Assembly.Cinema.Domain.Core.Repositories;
using Assembly.Cinema.Services.Interfaces;
using Cinema.Domain.Models;

namespace Assembly.Cinema.ConsoleApp.UserInterface;

internal class Start
{
    private readonly IUserServices _userServices;
    private readonly IUserRepository _userRepository;

    public Start(IUserServices userServices, IUserRepository userRepository)
    {
        _userServices = userServices;
        _userRepository = userRepository;
    }

    public void Run()
    {
        List<Review> reviews = new List<Review>();
        List<Ticket> pushasedTickts = new List<Ticket>();

        _userServices.Add(new User(new Name("Bruno", "Roma"), "bruno@gmail.com", "1234", reviews, pushasedTickts));

        foreach(var user in _userServices.GetAll())
        {
            Console.WriteLine(user.Name.FirstName);
        }
    }
}
