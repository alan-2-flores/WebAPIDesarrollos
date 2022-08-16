using DesarrollosAPI.Dto;
using DesarrollosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Controllers{
    [ApiController]
    [Route("api/Statuses")]
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStatus(string name)
        {
            var createdStatus = _statusService.Create(name);
            return Ok(createdStatus);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStatus(int id)
        {
            var obtainedStatus = _statusService.GetById(id);
            return Ok(obtainedStatus);
        }

        [HttpGet]
        public async Task<IActionResult> GetStatuses()
        {
            List<StatusResponse> response = new List<StatusResponse>();
            var obtainedStatuses = _statusService.GetAll();
            foreach (var status in obtainedStatuses)
            {
                response.Add(
                    new StatusResponse() {
                        Id=status.Id,
                        Name=status.Name
                    }
                    );
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStatus(int id, string name)
        {
            var updatedStatus = _statusService.Update(id, name);
            return Ok(updatedStatus);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            var deletedStatus = _statusService.Delete(id);
            return Ok(deletedStatus);
        }
    }
}
