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
    public class RescueTypeConfiguration : IEntityTypeConfiguration<RescueType>
    {
        public void Configure(EntityTypeBuilder<RescueType> builder)
        {
            builder.HasKey(x => x.code);

            builder.HasData(new RescueType()
            {
                code = "Fuel",
                name = "Tiếp nhiên liệu"
            });

            builder.HasData(new RescueType()
            {
                code = "Key",
                name = "Sửa khóa"
            });

            builder.HasData(new RescueType()
            {
                code = "Repair",
                name = "Sửa chữa"
            });

            builder.HasData(new RescueType()
            {
                code = "Rescue",
                name = "Trường hợp cứu hộ khác"
            });
        }
    }
}
