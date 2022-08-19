using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesarrollosAPI.Persistence
{
    public class AssignmentRepository : RepositoryBase<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        override public async Task<Assignment> GetById(Expression<Func<Assignment, bool>> filter)
        {
            return await RepositoryContext.Set<Assignment>().Include(project => project.Proposal).Include(company => company.Company).Where(filter).AsNoTracking().FirstAsync();
        }

        override public async Task<IList<Assignment>> GetAll()
        {
            return await RepositoryContext.Set<Assignment>().Include(project => project.Proposal).Include(company => company.Company).AsNoTracking().ToListAsync();
        }

        //override public async Task<IList<Assignment>> GetAll()
        //{
        //    return await RepositoryContext.Assignments.AsNoTracking().ToListAsync();
        //    return await RepositoryContext.Assignments.Include(project => project.Project).Include(company => company.Company).AsNoTracking().ToListAsync();
        //}
    }
}
