using Microsoft.Extensions.DependencyInjection;
using Assembly.Cinema.Services.Interfaces;
using Assembly.Cinema.Services.Services;

namespace Assembly.Cinema.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationsServices(this IServiceCollection services)
    {
        services.AddScoped<IUserServices, UserServices>();
        return services;
    }
}
