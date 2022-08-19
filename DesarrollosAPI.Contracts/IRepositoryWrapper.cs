using System.Threading.Tasks;

namespace DesarrollosAPI.Contracts
{
    public interface IRepositoryWrapper
    {
        IAssignmentRepository Assignment { get; }
        ICompanyRepository Company { get; }
        IProposalRepository Proposal { get; }
        Task Save();
    }
}
