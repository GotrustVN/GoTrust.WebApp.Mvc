using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Extensions
{
    public static class HealthInsuranceDetailExtension
    {
        public static void CalculateTotal(this HealthInsuranceDetail detail)
        {
            detail.totalAmount = detail.totalDiscount + detail.totalAdd + detail.vat;
        }
    }
}
