using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers
{
    [Route("api/Assignments")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        public AssignmentController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignment(Assignment assignment)
        {
            _repository.Assignment.Create(assignment);
            _repository.Save();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAssignment(int id)
        {
            var obtainedAssignment = _repository.Assignment.GetById(assignment => assignment.Id==id);
            return Ok(obtainedAssignment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAssignments()
        {
            var obtainedAssignments = _repository.Assignment.GetAll();
            return Ok(obtainedAssignments);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAssignment(Assignment assignment)
        {
            _repository.Assignment.Update(assignment);
            _repository.Save();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var assignment = _repository.Assignment.GetEntity(assignment => assignment.Id == id);
            _repository.Assignment.Delete(assignment);
            _repository.Save();
            return Ok();
        }
    }
}
