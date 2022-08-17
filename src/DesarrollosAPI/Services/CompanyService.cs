using DesarrollosAPI.Dto;
using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly RepositoryContext _dbContext;
        public CompanyService(RepositoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public CompanyResponse Create(string name, string address)
        {
            Company company = new()
            {
                Name = name,
                Address = address
            };
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return new CompanyResponse(company.Id, company.Name, company.Address);
        }

        public Company GetCompanyEntity(int id) {
            var search = _dbContext.Companies.First(company => company.Id == id);
            return search;
        }

        public CompanyResponse GetById(int id)
        {
            var search = _dbContext.Companies.First(company => company.Id == id);
            return new CompanyResponse(search.Id, search.Name, search.Address);
        }
        public List<CompanyResponse> GetAll()
        {
            List<CompanyResponse> response = new();
            var obtainedCompanies = _dbContext.Companies.ToList();
            foreach (var company in obtainedCompanies)
            {
                response.Add(
                    new CompanyResponse(company.Id, company.Name, company.Address)
                    );
            }
            return response;
        }
        public CompanyResponse Update(int id, string name, string address)
        {
            var dbCompany = GetCompanyEntity(id);
            dbCompany.Name = name;
            dbCompany.Address = address;
            _dbContext.SaveChanges();
            var company = GetById(id);
            return company;
        }
        public CompanyResponse Delete(int id)
        {
            var dbCompany = GetCompanyEntity(id);
            _dbContext.Companies.Remove(dbCompany);
            _dbContext.SaveChanges();
            var company = GetById(id);
            return company;
        }
    }
}
