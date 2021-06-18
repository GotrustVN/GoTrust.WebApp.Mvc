using AutoMapper;
using Payment.API.Models;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.MappingProfile
{
    public class HealthInsuranceRequestMapping : Profile
    {
        public HealthInsuranceRequestMapping()
        {
            CreateMap<HealthInsuranceOrderCreateRequestModel, HealthInsuranceOrder>();
            CreateMap<HealthInsuranceOrderUpdateRequestModel, HealthInsuranceOrder>();
            CreateMap<HealthInsuranceDetailCreateRequestModel, HealthInsuranceDetail>();
            CreateMap<HealthInsurancePaymentRequestModel, HealthInsurancePayment>();
        }
    }
}
