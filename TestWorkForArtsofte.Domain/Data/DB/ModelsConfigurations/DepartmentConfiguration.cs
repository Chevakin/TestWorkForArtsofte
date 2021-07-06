using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DB.ModelsConfigurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments")
                .HasKey(d => d.ID);

            builder.Property(d => d.ID)
                .ValueGeneratedOnAdd();

            builder.Property(d => d.Title)
                .IsRequired();

            builder.Property(d => d.Floor)
                .IsRequired();
        }
    }
}
