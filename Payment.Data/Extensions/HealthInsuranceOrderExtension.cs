using Payment.Data.Entities;
using Payment.SharedUltilities.Extensions;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Extensions
{
    public static class HealthInsuranceOrderExtension
    {
        public static void SetDefaultValue(this HealthInsuranceOrder order)
        {
            if (string.IsNullOrEmpty(order.code))
            {
                order.code = AppGlobal.DefaultStringCode;
            }
        }

        public static void UpdateBuyerInfor(this HealthInsuranceOrder order)
        {
            if(order.buyer != null)
            {
                var properties = order.GetType().GetProperties();

                if (string.IsNullOrEmpty(order.buyerName))
                    order.buyerName = order.buyer.name;

                if (string.IsNullOrEmpty(order.buyerType))
                    order.buyerType = order.buyer.name;

                if (string.IsNullOrEmpty(order.buyerGender))
                    order.buyerGender = order.buyer.gender?.code;

                if (string.IsNullOrEmpty(order.buyerProvince))
                    order.buyerProvince = order.buyer.province?.code;

                if (string.IsNullOrEmpty(order.buyerDistrict))
                    order.buyerDistrict = order.buyer.district?.code;

                if (string.IsNullOrEmpty(order.buyerWard))
                    order.buyerWard = order.buyer.ward?.code;

                if (string.IsNullOrEmpty(order.buyerAddress))
                    order.buyerAddress = order.buyer.address;

                if (string.IsNullOrEmpty(order.buyerFullAddress))
                    order.buyerFullAddress = order.buyer.fullAddress;

                if (string.IsNullOrEmpty(order.buyerPhone))
                    order.buyerPhone = order.buyer.phone;

                if (string.IsNullOrEmpty(order.buyerEmail))
                    order.buyerEmail = order.buyer.email;

                if (string.IsNullOrEmpty(order.buyerFax))
                    order.buyerFax = order.buyer.fax;

                if (string.IsNullOrEmpty(order.buyerIdentityNumber))
                    order.buyerIdentityNumber = order.buyer.identityNumber;

                if (string.IsNullOrEmpty(order.buyerIdentityPlace))
                    order.buyerIdentityPlace = order.buyer.identityPlace;

                if (order.buyerIdentityDate == null)
                    order.buyerIdentityDate = order.buyer.identityDate;

                if (order.buyerDateOfBirth == null)
                    order.buyerDateOfBirth = order.buyer.dateOfBirth;
            }
        }
    }
}
