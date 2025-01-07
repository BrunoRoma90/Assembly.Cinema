using Assembly.Cinema.Data.InMemory.Repository;
using Assembly.Cinema.Domain.Core.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Assembly.Cinema.Data.InMemory
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataInMemoryServices(this IServiceCollection services)
        {
            services.AddSingleton<Database>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
