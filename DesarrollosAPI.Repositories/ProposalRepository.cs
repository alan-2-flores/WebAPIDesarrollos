using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;

namespace DesarrollosAPI.Persistence
{
    public class ProposalRepository : RepositoryBase<Proposal>, IProposalRepository
    {
        public ProposalRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
