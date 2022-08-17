using DesarrollosAPI.Dto;
using DesarrollosAPI.Models;
using System.Collections.Generic;

namespace DesarrollosAPI.Services
{
    public interface ICompanyService
    {
        CompanyResponse Create(string name, string address);
        CompanyResponse GetById(int id);
        List<CompanyResponse> GetAll();
        CompanyResponse Update(int id, string name, string address);
        CompanyResponse Delete(int id);
    }
}
