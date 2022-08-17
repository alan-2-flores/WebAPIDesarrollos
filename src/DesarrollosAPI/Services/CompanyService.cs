using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task Create(CompanyRequest companyRequest)
        {
            Company company = _mapper.Map<Company>(companyRequest);
            _repository.Company.Create(company);
            await _repository.Save();
        }
        public async Task<CompanyResponse> GetById(int id)
        {
            var obtainedCompany = await _repository.Company.GetById(company => company.Id == id);
            CompanyResponse companyResponse = _mapper.Map<CompanyResponse>(obtainedCompany);
            return companyResponse;
        }
        public async Task<List<CompanyResponse>> GetAll()
        {
            List<CompanyResponse> companiesResponses = new List<CompanyResponse>();
            var obtainedCompanies = await _repository.Company.GetAll();
            foreach (var company in obtainedCompanies) {
                companiesResponses.Add(_mapper.Map<CompanyResponse>(company));
            }
            return companiesResponses;
        }

        public async Task Update(CompanyRequestWithId companyRequest)
        {
            Company company = _mapper.Map<Company>(companyRequest);
            _repository.Company.Update(company);
            await _repository.Save();
        }

        public async Task Delete(int id)
        {
            var obtainedCompany = await _repository.Company.GetById(company => company.Id == id);
            _repository.Company.Delete(obtainedCompany);
            await _repository.Save();
        }
    }
}
