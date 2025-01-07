using Assembly.Cinema.ConsoleApp.UserInterface;
using Assembly.Cinema.IoC;
using Microsoft.Extensions.DependencyInjection;

//Inicializar tudo (infra, data)

// Seed Data


        var services = new ServiceCollection();

        services.AddServices();
        services.AddSingleton<Start>();

        using var serviceProvider = services.BuildServiceProvider();