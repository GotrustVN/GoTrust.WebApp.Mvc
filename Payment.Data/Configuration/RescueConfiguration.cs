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
    public class RescueConfiguration : IEntityTypeConfiguration<Rescue>
    {
        public void Configure(EntityTypeBuilder<Rescue> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.createdAt).HasDefaultValue(DateTime.Now);
        }
    }
}
