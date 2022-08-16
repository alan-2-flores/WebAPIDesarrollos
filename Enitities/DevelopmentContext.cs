using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities
{
    public class DevelopmentContext:DbContext
    {
        public DevelopmentContext(DbContextOptions options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
