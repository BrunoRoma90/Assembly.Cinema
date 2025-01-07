using Assembly.Cinema.Data.InMemory;
using Assembly.Cinema.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Assembly.Cinema.IoC
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddServices();

            services.AddDataInMemoryServices();
        }
    }
}
