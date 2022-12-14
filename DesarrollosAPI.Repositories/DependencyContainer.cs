using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesarrollosAPI.Persistence
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SQLServer"),
                    x => x.MigrationsAssembly(typeof(RepositoryContext).Assembly.GetName().Name));
                //options.UseSqlServer(origen => origen.MigrationsAssembly("DesarrollosAPI"));
            });
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            return services;
        }
    }
}
