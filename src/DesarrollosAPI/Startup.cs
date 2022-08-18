using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using DesarrollosAPI.Repository;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DesarrollosAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SQLServer")));
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DesarrollosAPI", Version = "v1" });
            });
            //Mapper
            var mapperConf = new MapperConfiguration(m =>
            {
                m.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConf.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DesarrollosAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
