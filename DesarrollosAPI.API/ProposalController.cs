using DesarrollosAPI.DTOS;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
//separar interfaces de services en su respectiva carpeta
namespace DesarrollosAPI.API
{
    [Authorize]
    [Route("api/Projects")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProposalService _projectService;
        public ProposalController(IProposalService service)
        {
            _projectService = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(ProposalRequest projectRequest)
        {
            await _projectService.Create(projectRequest);
            return Ok("Project added succesfuly");
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var obtainedProject = await _projectService.GetById(id);
            return Ok(obtainedProject);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var obtainedProjects = await _projectService.GetAll();
            return Ok(obtainedProjects);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(ProposalRequestWithId projectRequest)
        {
            await _projectService.Update(projectRequest);
            return Ok("Project Updated succesfuly");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await _projectService.Delete(id);
            return Ok("Project Deleted succesfuly");
        }
    }
}
