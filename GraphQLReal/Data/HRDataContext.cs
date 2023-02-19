using GraphQLReal.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLReal.Data
{
    public class HRDataContext : DbContext
    {
        public HRDataContext(DbContextOptions<HRDataContext> options):base(options) { }
       

        public DbSet<Country> Country { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Dependents> Dependents { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Job> Job { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<Regions> Regions { get; set; }
    }
}
