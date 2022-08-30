using DesarrollosAPI.DTOS;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesarrollosAPI.API
{
    //[Authorize(Roles ="Admin")]
    [Authorize]
    [Route("api/Assignments")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService service)
        {
            _assignmentService = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignment(AssignmentRequest assignmentRequest)
        {
            await _assignmentService.Create(assignmentRequest);
            return Ok("Assignment added succesfuly");
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAssignment(int id)
        {
            var obtainedAssignment = await _assignmentService.GetById(id);
            return Ok(obtainedAssignment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAssignments()
        {
            var obtainedAssignments = await _assignmentService.GetAll();
            return Ok(obtainedAssignments);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAssignment(AssignmentRequestWithId assignmentRequest)
        {
            await _assignmentService.Update(assignmentRequest);
            return Ok("Assignment Updated succesfuly");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            await _assignmentService.Delete(id);
            return Ok("Assignment Deleted succesfuly");
        }
    }
}
