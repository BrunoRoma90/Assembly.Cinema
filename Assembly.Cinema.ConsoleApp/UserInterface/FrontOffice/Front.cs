using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.ConsoleApp.UserInterface.FrontOffice;

internal class Front
{
    private readonly IUserRepository _userRepository;

    public Front(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Run()
    {
        Console.WriteLine("welcome to front");
    }
}
