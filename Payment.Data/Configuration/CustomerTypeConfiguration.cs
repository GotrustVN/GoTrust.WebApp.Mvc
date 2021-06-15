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
    public class CustomerTypeConfiguration : IEntityTypeConfiguration<CustomerType>
    {
        public void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            builder.HasKey(x => x.code);

            builder.Property(x => x.name)
                .HasMaxLength(1000);

            builder.Property(x => x.createdAt)
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.lastUpdatedAt)
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);

            builder.HasData(new CustomerType
            {
                code = "CN",
                name = "Cá nhân"
            });

            builder.HasData(new CustomerType
            {
                code = "CQ",
                name = "Cơ quan"
            });

            builder.HasData(new CustomerType
            {
                code = "DN",
                name = "Doanh nghiệp"
            });
        }
    }
}
