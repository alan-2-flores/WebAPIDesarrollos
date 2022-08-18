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
    [Route("api/Projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService service)
        {
            _projectService = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(ProjectRequest projectRequest)
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
        public async Task<IActionResult> UpdateCompany(ProjectRequestWithId projectRequest)
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
