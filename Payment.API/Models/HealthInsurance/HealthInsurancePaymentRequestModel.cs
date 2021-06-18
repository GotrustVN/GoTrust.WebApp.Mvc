using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class HealthInsurancePaymentRequestModel
    {
        public string paymentType { get; set; }
        public DateTime payDate { get; set; }
    }
}
