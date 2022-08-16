using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers
{
    [ApiController]
    [Route("api/Projects")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStatus(string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate)
        {
            var createdProject = _projectService.Create(name, description, startDate, deadLineDate, endDate);
            return Ok(createdProject);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStatus(int id)
        {
            var obtainedProject = _projectService.GetById(id);
            return Ok(obtainedProject);
        }

        [HttpGet]
        public async Task<IActionResult> GetStatuses()
        {
            var obtainedStatuses = _projectService.GetAll();
            return Ok(obtainedStatuses);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStatus(int id, string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate)
        {
            var updatedProject = _projectService.Update(id, name, description, startDate, deadLineDate, endDate);
            return Ok(updatedProject);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            var deletedProject = _projectService.Delete(id);
            return Ok(deletedProject);
        }
    }
}
