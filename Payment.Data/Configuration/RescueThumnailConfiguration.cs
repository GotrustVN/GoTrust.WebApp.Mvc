﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Configuration
{
    public class RescueThumnailConfiguration : IEntityTypeConfiguration<RescueThumbnail>
    {
        public void Configure(EntityTypeBuilder<RescueThumbnail> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.refUrl)
                .HasMaxLength(1000);
        }
    }
}
