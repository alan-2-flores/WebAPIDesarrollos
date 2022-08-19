using DesarrollosAPI.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public interface IAssignmentService
    {
        Task Create(AssignmentRequest assignmentRequest);
        Task<AssignmentResponse> GetById(int id);
        Task<List<AssignmentResponse>> GetAll();
        Task Update(AssignmentRequestWithId assignmentRequest);
        Task Delete(int id);
    }
}
