﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            // Services
            // AddApplicationServices()
            // AddApiServices(configuration);
            return services;
        }
    }
}
