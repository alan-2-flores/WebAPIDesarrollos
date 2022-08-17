using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    //->CONTROLADOR
    //->DTO
    //->SERVICE
    //->REPO
    public class CompanyService:ICompanyService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public CompanyService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(CompanyRequest companyRequest)
        {
            Company company = _mapper.Map<Company>(companyRequest);
            _repository.Company.Create(company);
            _repository.Save();
        }
        public CompanyResponse GetById(int id)
        {
            var obtainedCompany = _repository.Company.GetById(company => company.Id == id).First();
            CompanyResponse companyResponse = _mapper.Map<CompanyResponse>(obtainedCompany);
            return companyResponse;
        }
        public List<CompanyResponse> GetAll()
        {
            List<CompanyResponse> companiesResponses = new List<CompanyResponse>();
            var obtainedCompanies = _repository.Company.GetAll();
            foreach (var company in obtainedCompanies) {
                companiesResponses.Add(_mapper.Map<CompanyResponse>(company));
            }
            return companiesResponses;
        }

        public void Update(CompanyRequestWithId companyRequest)
        {
            Company company = _mapper.Map<Company>(companyRequest);
            _repository.Company.Update(company);
            _repository.Save();
        }

        public void Delete(int id)
        {
            var obtainedCompany = _repository.Company.GetById(company => company.Id == id).First();
            _repository.Company.Delete(obtainedCompany);
            _repository.Save();
        }
    }
}
