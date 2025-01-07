using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.ConsoleApp.UserInterface.BackOffice;

internal class AdminPainel
{
    private readonly IUserRepository _userRepository;

    public AdminPainel(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Run()
    {
        Console.WriteLine("Welcome Admin");
    }
}
