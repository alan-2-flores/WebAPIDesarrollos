using DesarrollosAPI.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public interface ICompanyService
    {
        Task Create(CompanyRequest companyRequest);
        Task<CompanyResponse> GetById(int id);
        Task<List<CompanyResponse>> GetAll();
        Task Update(CompanyRequestWithId companyRequest);
        Task Delete(int id);
    }
}
