using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly DevelopmentContext _dbContext;
        public CompanyService(DevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Company Create(string name, string address)
        {
            Company company = new()
            {
                name = name,
                address = address
            };
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return company;
        }
        public Company GetById(int id)
        {
            var search = _dbContext.Companies.First(company => company.Id == id);
            return search;
        }
        public IEnumerable<Company> GetAll()
        {
            return _dbContext.Companies.ToList();
        }
        public Company Update(int id, string name, string address)
        {
            var company = GetById(id);
            company.name = name;
            company.address = address;
            _dbContext.SaveChanges();
            return company;
        }
        public Company Delete(int id)
        {
            var company = GetById(id);
            _dbContext.Companies.Remove(company);
            _dbContext.SaveChanges();
            return company;
        }
    }
}
