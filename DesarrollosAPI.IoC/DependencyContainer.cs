using DesarrollosAPI.API;
using DesarrollosAPI.DTOS;
using DesarrollosAPI.Persistence;
using DesarrollosAPI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesarrollosAPI.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApiControllers()
                .AddServices()
                .AddMapper()
                .AddPersistence(configuration);
            return services;
        }
    }
}
