using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DB.ModelsConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees")
                .HasKey(e => e.ID);

            builder
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees);

            builder
                .HasOne(e => e.ProgrammingLanguage)
                .WithMany(e => e.Employees);

            builder.Property(e => e.ID)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired();

            builder.Property(e => e.Surname)
                .IsRequired();

            builder.Property(e => e.Age)
                .IsRequired();

            builder.Property(e => e.Gender)
                .IsRequired();
        }
    }
}
