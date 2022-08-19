using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;
using System.Threading.Tasks;

namespace DesarrollosAPI.Persistence
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repositoryContext;
        private IAssignmentRepository _assignment;
        private ICompanyRepository _company;
        private IProposalRepository _proposal;
        public IAssignmentRepository Assignment
        {
            get
            {
                if (_assignment == null)
                {
                    _assignment = new AssignmentRepository(_repositoryContext);
                }
                return _assignment;
            }
        }
        public ICompanyRepository Company
        {
            get
            {
                if (_company == null)
                {
                    _company = new CompanyRepository(_repositoryContext);
                }
                return _company;
            }
        }
        public IProposalRepository Proposal
        {
            get
            {
                if (_proposal == null)
                {
                    _proposal = new ProposalRepository(_repositoryContext);
                }
                return _proposal;
            }
        }
        public async Task Save()
        {
            await _repositoryContext.SaveChangesAsync();
        }

        public RepositoryWrapper(RepositoryContext repositoryContex)
        {
            _repositoryContext = repositoryContex;
        }
    }
}
