using Assembly.Cinema.Data.Ado.Net.Repositories;
using Assembly.Cinema.Domain.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Assembly.Cinema.Data.Ado.Net
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAdoNetServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
