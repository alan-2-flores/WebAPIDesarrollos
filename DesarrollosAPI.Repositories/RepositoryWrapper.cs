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
        private IProjectRepository _project;
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
        public IProjectRepository Project
        {
            get
            {
                if (_project == null)
                {
                    _project = new ProjectRepository(_repositoryContext);
                }
                return _project;
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
