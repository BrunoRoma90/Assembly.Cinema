using Assembly.Cinema.Data.InMemory;

using Microsoft.Extensions.DependencyInjection;
using Assembly.Cinema.Services;

namespace Assembly.Cinema.IoC;

public static class DependencyInjection
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddApplicationsServices();

        services.AddDataInMemoryServices();
    }
}
