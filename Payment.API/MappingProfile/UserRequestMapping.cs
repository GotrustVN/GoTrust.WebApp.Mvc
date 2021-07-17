using AutoMapper;
using Payment.API.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.MappingProfile
{
    public class UserRequestMapping : Profile
    {
        public UserRequestMapping()
        {
            CreateMap<RegisterRequestModel, User>();
            CreateMap<User, AuthenticateRequestModel>();
        }
    }
}
