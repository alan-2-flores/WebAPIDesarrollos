using Microsoft.Extensions.DependencyInjection;

namespace DesarrollosAPI.Services
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IProposalService, ProposalService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            return services;
        }
    }
}
