using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Configuration
{
    public class FileImportConfiguration : IEntityTypeConfiguration<FileImport>
    {
        public void Configure(EntityTypeBuilder<FileImport> builder)
        {
            builder.HasKey(x => x.code);
            builder.Property(x => x.fileName)
                .HasMaxLength(4000);
            builder.Property(x => x.savePath)
                .HasMaxLength(4000);

            builder.Property(x => x.createdAt)
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.lastUpdatedAt)
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
