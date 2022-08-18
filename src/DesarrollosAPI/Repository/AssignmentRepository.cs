using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Repository
{
    public class AssignmentRepository : RepositoryBase<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        override public async Task<IList<Assignment>> GetAll()
        {
            return await RepositoryContext.Set<Assignment>().Include(project => project.Project).Include(company => company.Company).AsNoTracking().ToListAsync();
        }

        //override public async Task<IList<Assignment>> GetAll()
        //{
        //    return await RepositoryContext.Assignments.AsNoTracking().ToListAsync();
        //    return await RepositoryContext.Assignments.Include(project => project.Project).Include(company => company.Company).AsNoTracking().ToListAsync();
        //}
    }
}
