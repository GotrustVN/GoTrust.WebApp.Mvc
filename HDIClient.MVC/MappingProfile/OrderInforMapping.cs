using AutoMapper;
using HDIClient.MVC.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.MappingProfile
{
    public class OrderInforMapping : Profile
    {
        public OrderInforMapping()
        {
            CreateMap<PaymentDetailViewModel, OrderInfor>();
        }
    }
}
