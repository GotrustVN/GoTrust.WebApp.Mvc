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
    public class HealthInsuranceDetailConfiguration : IEntityTypeConfiguration<HealthInsuranceDetail>
    {
        public void Configure(EntityTypeBuilder<HealthInsuranceDetail> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id)
                .UseIdentityColumn();
            builder.Property(x => x.fees)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.amount)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.vat)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalDiscount)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalAdd)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalAmount)
                .HasDefaultValue(0)
                .HasColumnType("decimal(19,9)");

            builder.HasOne(x => x.order).WithMany(z => z.Details);

        }
    }
}
