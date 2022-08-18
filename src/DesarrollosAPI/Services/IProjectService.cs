using DesarrollosAPI.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public interface IProjectService
    {
        Task Create(ProjectRequest projectRequest);
        Task<ProjectResponse> GetById(int id);
        Task<List<ProjectResponse>> GetAll();
        Task Update(ProjectRequestWithId projectRequest);
        Task Delete(int id);
    }
}
