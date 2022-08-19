using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;

namespace DesarrollosAPI.Persistence
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
