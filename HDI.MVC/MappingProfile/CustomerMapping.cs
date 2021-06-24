using AutoMapper;
using HDI.MVC.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.MappingProfile
{
    public class CustomerMapping : Profile
    {
        public CustomerMapping()
        {
            CreateMap<CustomerCreateViewModel, Customer>();
            CreateMap<CustomerEditViewModel, Customer>();
            CreateMap<Customer, CustomerEditViewModel>()
                .ForMember(x => x.typeCode, y => y.MapFrom(s => s.type.code))
                .ForMember(x => x.districtCode, y => y.MapFrom(s => s.district.code))
                .ForMember(x => x.wardCode, y => y.MapFrom(s => s.ward.code))
                .ForMember(x => x.genderCode, y => y.MapFrom(s => s.gender.code))
                .ForMember(x => x.provinceCode, y => y.MapFrom(s => s.province.code));
            CreateMap<Customer, CustomerDetailViewModel>();
        }
    }
}
