using DesarrollosAPI.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public interface IProposalService
    {
        Task Create(ProposalRequest projectRequest);
        Task<ProposalResponse> GetById(int id);
        Task<List<ProposalResponse>> GetAll();
        Task Update(ProposalRequestWithId projectRequest);
        Task Delete(int id);
    }
}
