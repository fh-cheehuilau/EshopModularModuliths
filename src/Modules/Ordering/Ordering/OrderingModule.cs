using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            // Services
            // AddApplicationServices()
            // AddApiServices(configuration);

            return services;
        }
    }
}
