using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using System.Collections.Generic;

namespace DesarrollosAPI.Services
{
    public interface ICompanyService
    {
        void Create(CompanyRequest companyRequest);
        CompanyResponse GetById(int id);
        List<CompanyResponse> GetAll();
        void Update(CompanyRequestWithId companyRequest);
        void Delete(int id);
        //CompanyResponse Delete(int id);
    }
}
