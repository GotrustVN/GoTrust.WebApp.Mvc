﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Data.Configuration
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
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

            builder.HasData(new OrderStatus()
            {
                code = "00001",
                name = "Chưa thanh tóan",
                backgroundColor = "transparent",
                forceColor = "black"
            });

            builder.HasData(new OrderStatus()
            {
                code = "00002",
                name = "Đã thanh tóan",
                backgroundColor = "transparent",
                forceColor = "green"
            });

            builder.HasData(new OrderStatus()
            {
                code = "00003",
                name = "Giao dịch lỗi",
                backgroundColor = "transparent",
                forceColor = "red"
            });
        }
    }
}
