using AutoMapper;
using Payment.API.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.MappingProfile
{
    public class CustomerRequestMapping : Profile
    {
        public CustomerRequestMapping()
        {
            CreateMap<CustomerCreateRequestModel, Customer>();
            CreateMap<CustomerUpdateRequestModel, Customer>();
        }
    }
}
