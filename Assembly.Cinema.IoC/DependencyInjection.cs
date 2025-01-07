using Assembly.Cinema.Data.InMemory;
using Assembly.Cinema.Data.
using Microsoft.Extensions.DependencyInjection;

namespace Assembly.Cinema.IoC;

public static class DependencyInjection
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDataAdoNetServices();

        services.AddDataInMemoryServices();
    }
}
