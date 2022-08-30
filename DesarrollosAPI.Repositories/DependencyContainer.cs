using DesarrollosAPI.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesarrollosAPI.Persistence
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<RepositoryContext>(options =>
            //{
            //    options.UseSqlServer(configuration.GetConnectionString("SQLServer"),
            //        x => x.MigrationsAssembly(typeof(RepositoryContext).Assembly.GetName().Name));
            //    options.UseSqlServer(origen => origen.MigrationsAssembly("DesarrollosAPI.Repositories"));
            //});

            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SQLServer"),
                    x => x.MigrationsAssembly(typeof(RepositoryContext).Assembly.GetName().Name));
                //options.UseSqlServer(origen => origen.MigrationsAssembly("DesarrollosAPI.Repositories"));
            });
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            return services;
        }
    }
}

//dotnet ef database update --project .\DesarrollosAPI.Repositories\ --startup-project .\src\DesarrollosAPI\

//dotnet ef migrations add initialdb -s .\src\DesarrollosAPI\ -p .\DesarrollosAPI.Repositories\