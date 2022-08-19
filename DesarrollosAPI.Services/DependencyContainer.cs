using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
