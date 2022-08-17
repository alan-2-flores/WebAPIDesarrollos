using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;

namespace DesarrollosAPI.Repository
{
    public class AssignmentRepository : RepositoryBase<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
