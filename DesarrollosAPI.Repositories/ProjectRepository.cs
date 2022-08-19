using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;

namespace DesarrollosAPI.Persistence
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
