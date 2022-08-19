using AutoMapper;
using DesarrollosAPI.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
