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
    public class HealthInsurancePaymentConfiguration : IEntityTypeConfiguration<HealthInsurancePayment>
    {
        public void Configure(EntityTypeBuilder<HealthInsurancePayment> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id)
                .UseIdentityColumn();
            builder.Property(x => x.paymentType)
                .HasMaxLength(1000);
            builder.Property(x => x.payDate)
                .HasColumnType("datetime");
        }
    }
}
