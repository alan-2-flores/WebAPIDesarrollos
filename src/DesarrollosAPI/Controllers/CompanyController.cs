using DesarrollosAPI.Models;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers
{
    [ApiController]
    [Route("api/Companies")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(string name, string address)
        {
            var createdCompany = _companyService.Create(name, address);
            return Ok(createdCompany);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var obtainedCompany = _companyService.GetById(id);
            return Ok(obtainedCompany);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var obtainedCompanies = _companyService.GetAll();
            return Ok(obtainedCompanies);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(int id, string name, string address) {
            var updatedCompany = _companyService.Update(id, name, address);
            return Ok(updatedCompany);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var deletedCompany = _companyService.Delete(id);
            return Ok(deletedCompany);
        }
    }
}
