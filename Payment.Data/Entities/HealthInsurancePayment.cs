using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class HealthInsurancePayment
    {
        public int id { get; set; }
        public string paymentType { get; set; }
        public DateTime payDate { get; set; }
    }
}
