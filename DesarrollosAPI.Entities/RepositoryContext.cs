using Microsoft.EntityFrameworkCore;

namespace DesarrollosAPI.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<Company> Companies { get; }
        public DbSet<Proposal> Proposals { get; }
        public DbSet<Assignment> Assignments { get; }
    }
}