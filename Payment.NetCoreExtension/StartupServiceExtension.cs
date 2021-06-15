using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using Payment.ExternalService;
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
            services.AddScoped<IGenericRepository<Province>, GenericRepository<Province>>();
            services.AddScoped<IGenericRepository<District>, GenericRepository<District>>();
            services.AddScoped<IGenericRepository<Ward>, GenericRepository<Ward>>();
            services.AddScoped<IGenericRepository<Gender>, GenericRepository<Gender>>();
        }
    }
}
