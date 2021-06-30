using AutoMapper;
using HDIClient.MVC.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.MappingProfile
{
    public class CustomerMapping : Profile
    {
        public CustomerMapping()
        {
            CreateMap<Customer, CustomerDetailViewModel>()
                .ForMember(x => x.typeCode, y => y.MapFrom(s => s.type.code))
                .ForMember(x => x.genderCode, y => y.MapFrom(s => s.gender.code));

            CreateMap<CustomerDetailViewModel, Customer>();
        }
    }
}
