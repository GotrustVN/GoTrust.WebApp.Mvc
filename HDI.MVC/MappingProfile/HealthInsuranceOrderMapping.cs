using AutoMapper;
using HDI.MVC.Models;
using Payment.Data.Entities;
using Payment.ExternalService.HDInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.MappingProfile
{
    public class HealthInsuranceOrderMapping : Profile
    {
        public HealthInsuranceOrderMapping()
        {
            CreateMap<HealthInsuranceOrder, HealthInsuranceOrderRequest>()
               .ForPath(x => x.Data.BUYER.CUS_ID, y => y.MapFrom(s => s.buyerCode))
               .ForPath(x => x.Data.BUYER.TYPE, y => y.MapFrom(s => s.buyerType))
               .ForPath(x => x.Data.BUYER.NATIONALITY, y => y.MapFrom(s => s.buyerNationality))
               .ForPath(x => x.Data.BUYER.NAME, y => y.MapFrom(s => s.buyerName))
               .ForPath(x => x.Data.BUYER.DOB, y => y.MapFrom(s => s.buyerDateOfBirth.GetValueOrDefault().ToString("dd/MM/yyy")))
               .ForPath(x => x.Data.BUYER.GENDER, y => y.MapFrom(s => s.buyerGender))
               .ForPath(x => x.Data.BUYER.PROV, y => y.MapFrom(s => s.buyerProvince))
               .ForPath(x => x.Data.BUYER.DIST, y => y.MapFrom(s => s.buyerDistrict))
               .ForPath(x => x.Data.BUYER.WARDS, y => y.MapFrom(s => s.buyerWard))
               .ForPath(x => x.Data.BUYER.ADDRESS, y => y.MapFrom(s => s.buyerAddress))
               .ForPath(x => x.Data.BUYER.IDCARD, y => y.MapFrom(s => s.buyerIdentityNumber))
               .ForPath(x => x.Data.BUYER.EMAIL, y => y.MapFrom(s => s.buyerEmail))
               .ForPath(x => x.Data.BUYER.PHONE, y => y.MapFrom(s => s.buyerPhone))
               .ForPath(x => x.Data.BUYER.FAX, y => y.MapFrom(s => s.buyerFax))
               .ForPath(x => x.Data.BUYER.TAXCODE, y => y.MapFrom(s => s.buyerTaxCode))
               .ForMember(x => x.Action, y => y.Ignore())
               .ForMember(x => x.Device, y => y.Ignore());
            CreateMap<HealthInsuranceDetail, HealthInsurance>()
                .ForMember(x => x.CUS_ID, y => y.MapFrom(s => s.customerCode))
                .ForMember(x => x.TYPE, y => y.MapFrom(s => s.customerType))
                .ForMember(x => x.NATIONALITY, y => y.MapFrom(s => s.customerNationality))
                .ForMember(x => x.NAME, y => y.MapFrom(s => s.customerName))
                .ForMember(x => x.DOB, y => y.MapFrom(s => s.customerDateOfBirth.ToString("dd/MM/yyyy")))
                .ForMember(x => x.GENDER, y => y.MapFrom(s => s.customerGender))
                .ForMember(x => x.PROV, y => y.MapFrom(s => s.customerProvince))
                .ForMember(x => x.DIST, y => y.MapFrom(s => s.customerDistrict))
                .ForMember(x => x.WARDS, y => y.MapFrom(s => s.customerWard))
                .ForMember(x => x.ADDRESS, y => y.MapFrom(s => s.customerAddress))
                .ForMember(x => x.IDCARD, y => y.MapFrom(s => s.customerIdentityNumber))
                .ForMember(x => x.EMAIL, y => y.MapFrom(s => s.customerEmail))
                .ForMember(x => x.PHONE, y => y.MapFrom(s => s.customerPhone))
                .ForMember(x => x.FAX, y => y.MapFrom(s => s.customerFax))
                .ForMember(x => x.TAXCODE, y => y.MapFrom(s => s.customerTaxCode))
                .ForMember(x => x.RELATIONSHIP, y => y.MapFrom(s => s.relationship.code))
                .ForMember(x => x.PRODUCT_CODE, y => y.MapFrom(s => s.productCode))
                .ForMember(x => x.PACK_CODE, y => y.MapFrom(s => s.packCode))
                .ForMember(x => x.REGION, y => y.MapFrom(s => s.region))
                .ForMember(x => x.EFFECTIVE_DATE, y => y.MapFrom(s => s.effectiveDate.ToString("dd/MM/yyyy")))
                .ForMember(x => x.EXPIRATION_DATE, y => y.MapFrom(s => s.expirationDate.ToString("dd/MM/yyyy")))
                .ForMember(x => x.FEES, y => y.MapFrom(s => s.fees))
                .ForMember(x => x.AMOUNT, y => y.MapFrom(s => s.amount))
                .ForMember(x => x.TOTAL_DISCOUNT, y => y.MapFrom(s => s.totalDiscount))
                .ForMember(x => x.TOTAL_ADD, y => y.MapFrom(s => s.totalAdd))
                .ForMember(x => x.VAT, y => y.MapFrom(s => s.vat))
                .ForMember(x => x.TOTAL_AMOUNT, y => y.MapFrom(s => s.totalAmount));
            CreateMap<HealthInsuranceOrderCreateViewModel, HealthInsuranceOrder>()
                .ForMember(x => x.Details, y => y.Ignore());
            CreateMap<HealthInsuranceDetailViewModel, HealthInsuranceDetail>();
            CreateMap<HealthInsurancePaymentViewModel, HealthInsurancePayment>();
        }
    }
}
