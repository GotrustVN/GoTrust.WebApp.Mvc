using Payment.Data.Entities;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Extensions
{
    public static class CustomerExtension
    {
        public static void SetFullAddress(this Customer customer)
        {
            string fullAddress = customer.address;

            if (customer.ward != null)
            {
                fullAddress = fullAddress  + ", " + customer.ward.name;
            }

            if(customer.district != null)
            {
                fullAddress = fullAddress  + ", " + customer.district.name;
            }

            if (customer.province != null)
            {
                fullAddress = fullAddress  + ", " + customer.province.name;
            }

            customer.fullAddress = fullAddress;
        }

        public static void SetDefaultValue(this Customer customer)
        {
            if (string.IsNullOrEmpty(customer.code))
            {
                customer.code = AppGlobal.DefaultStringCode;
            }
        }
    }
}
