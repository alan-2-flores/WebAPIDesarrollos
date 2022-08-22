using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace DesarrollosAPI.API
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddApiControllers(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DesarrollosAPI", Version = "v1" });
            });
            services.AddControllers();
            return services;
        }
    }
}
