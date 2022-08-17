using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;

namespace DesarrollosAPI.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
