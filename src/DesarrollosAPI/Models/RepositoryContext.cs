using Microsoft.EntityFrameworkCore;

namespace DesarrollosAPI.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<Company> Companies { get; }
        public DbSet<Project> Projects { get; }
        public DbSet<Assignment> Assignments { get; }
    }
}
