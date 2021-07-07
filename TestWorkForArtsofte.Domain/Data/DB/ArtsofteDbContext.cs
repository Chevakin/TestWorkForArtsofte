using Microsoft.EntityFrameworkCore;
using TestWorkForArtsofte.Domain.Data.DB.ModelsConfigurations;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DB
{
    public class ArtsofteDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public ArtsofteDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new EmployeeConfiguration())
                .ApplyConfiguration(new DepartmentConfiguration())
                .ApplyConfiguration(new ProgrammingLanguageConfiguration());
        }
    }
}
