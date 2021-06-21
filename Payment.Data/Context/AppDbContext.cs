using Microsoft.EntityFrameworkCore;
using Payment.Data.Configuration;
using Payment.Data.Entities;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionGlobal.DatabaseConnectionString);
            }
        }
        #region DbSet
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<FileImport> FileImport { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<MasterCategory> MasterCategory { get; set; }
        public virtual DbSet<OrderInfor> OrderInfor { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<PaymentLog> PaymentLog { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<HealthInsuranceOrder> HealthInsuranceOrder { get; set; }
        public virtual DbSet<HealthInsuranceDetail> HealthInsuranceDetail { get; set; }
        public virtual DbSet<HealthInsurancePayment> HealthInsurancePayment { get; set; }
        public virtual DbSet<FileType> FileType { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new MasterCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderInforConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentLogConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FileImportConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());
            modelBuilder.ApplyConfiguration(new HealthInsuranceDetailConfiguration());
            modelBuilder.ApplyConfiguration(new HealthInsuranceOrderConfiguration());
            modelBuilder.ApplyConfiguration(new HealthInsurancePaymentConfiguration());
            modelBuilder.ApplyConfiguration(new FileTypeConfiguration());
        }

    }
}
