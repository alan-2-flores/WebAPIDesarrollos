using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;

namespace DesarrollosAPI.Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
