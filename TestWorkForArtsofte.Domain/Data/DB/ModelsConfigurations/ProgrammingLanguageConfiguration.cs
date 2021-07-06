using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DB.ModelsConfigurations
{
    public class ProgrammingLanguageConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
    {
        public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
        {
            builder.ToTable("Employees_ProgrammingLanguages")
                .HasKey(p => p.ID);

            builder.Property(p => p.ID)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
                .IsRequired();
        }
    }
}
