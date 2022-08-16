using DesarrollosAPI.Models;
using System.Collections.Generic;

namespace DesarrollosAPI.Services
{
    public interface ICompanyService
    {
        Company Create(string name, string address);
        Company GetById(int id);
        IEnumerable<Company> GetAll();
        Company Update(int id, string name, string address);
        Company Delete(int id);
    }
}
