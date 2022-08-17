using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers
{
    [Route("api/Projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        public ProjectController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(Project project)
        {
            _repository.Project.Create(project);
            _repository.Save();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var obtainedProject = _repository.Project.GetById(project => project.Id == id);
            return Ok(obtainedProject);
        }

        [HttpGet]
        public async Task<IActionResult> GetProjets()
        {
            var obtainedProjects = _repository.Project.GetAll();
            return Ok(obtainedProjects);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProject(Project project)
        {
            _repository.Project.Update(project);
            _repository.Save();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = _repository.Project.GetEntity(project => project.Id == id);
            _repository.Project.Delete(project);
            _repository.Save();
            return Ok();
        }
    }
}
