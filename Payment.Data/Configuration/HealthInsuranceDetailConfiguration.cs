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
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.amount)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.vat)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalDiscount)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalAdd)
                .HasColumnType("decimal(19,9)");
            builder.Property(x => x.totalAmount)
                .HasColumnType("decimal(19,9)");

            builder.HasOne(x => x.order).WithMany(z => z.Details);

        }
    }
}
