using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace DesarrollosAPI.DTOS
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var mapperConf = new MapperConfiguration(m =>
            {
                m.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConf.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
