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
    public class HealthInsuranceOrderConfiguration : IEntityTypeConfiguration<HealthInsuranceOrder>
    {
        public void Configure(EntityTypeBuilder<HealthInsuranceOrder> builder)
        {
            builder.HasKey(x => x.code);
        }
    }
}
