
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrollosAPI.Models
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<Company> Companies { get; }
        public DbSet<Project> Projects { get; }
        public DbSet<Assignment> Assignments { get; }
    }
}
