using Microsoft.Extensions.DependencyInjection;
using Assembly.Cinema.Services.Interfaces;
using Assembly.Cinema.Services.Services;

namespace Assembly.Cinema.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            return services;
        }
    }
}
