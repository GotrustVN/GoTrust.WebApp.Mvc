using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using Payment.ExternalService;
using Payment.ExternalService.HDInsurance;
using System;

namespace Payment.NetCoreExtension
{
    public static class StartupServiceExtension
    {
        public static void AddConnectedService(this IServiceCollection services)
        {
            services.AddScoped<IVNPayService, VNPayService>();
        }

        public static void AddRepostiories(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository<Bank>, GenericRepository<Bank>>();
            services.AddScoped<IGenericRepository<OrderType>, GenericRepository<OrderType>>();
            services.AddScoped<IGenericRepository<OrderStatus>, GenericRepository<OrderStatus>>();
            services.AddScoped<IGenericRepository<OrderInfor>, GenericRepository<OrderInfor>>();
            services.AddScoped<IGenericRepository<Language>, GenericRepository<Language>>();
            services.AddScoped<IGenericRepository<PaymentLog>, GenericRepository<PaymentLog>>();
            services.AddScoped<IGenericRepository<Customer>, GenericRepository<Customer>>();
            services.AddScoped<IGenericRepository<CustomerType>, GenericRepository<CustomerType>>();
            services.AddScoped<IGenericRepository<Province>, GenericRepository<Province>>();
            services.AddScoped<IGenericRepository<District>, GenericRepository<District>>();
            services.AddScoped<IGenericRepository<Ward>, GenericRepository<Ward>>();
            services.AddScoped<IGenericRepository<Gender>, GenericRepository<Gender>>();
            services.AddScoped<IGenericRepository<HealthInsuranceOrder>, GenericRepository<HealthInsuranceOrder>>();
            services.AddScoped<IGenericRepository<HealthInsurancePayment>, GenericRepository<HealthInsurancePayment>>();
            services.AddScoped<IGenericRepository<HealthInsuranceDetail>, GenericRepository<HealthInsuranceDetail>>();
            services.AddScoped<IGenericRepository<MasterCategory>, GenericRepository<MasterCategory>>();
            services.AddScoped<IGenericRepository<FileType>, GenericRepository<FileType>>();
            services.AddScoped<IGenericRepository<FileImport>, GenericRepository<FileImport>>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IMasterCategoryRepository, MasterCatetoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IHealthInsuranceOrderRepository, HealthInsuranceOrderRepository>();
        }

        public static void AddExternalService(this IServiceCollection services)
        {
            services.AddScoped<IHDIService, HDIService>();
            services.AddScoped<IVNPayService, VNPayService>();
        }

    }
}
