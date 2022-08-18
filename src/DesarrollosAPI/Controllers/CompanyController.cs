using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers
{
    [Route("api/Companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService service)
        {
            _companyService = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(CompanyRequest companyRequest)
        {
            await _companyService.Create(companyRequest);
            return Ok("Company added succesfuly");
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var obtainedCompany = await _companyService.GetById(id);
            return Ok(obtainedCompany);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var obtainedCompanies = await _companyService.GetAll();
            return Ok(obtainedCompanies);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(CompanyRequestWithId companyRequest)
        {
            await _companyService.Update(companyRequest);
            return Ok("Company Updated succesfuly");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await _companyService.Delete(id);
            return Ok("Company Deleted succesfuly");
        }

    }
}
