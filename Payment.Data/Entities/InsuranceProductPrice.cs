using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class InsuranceProductPrice
    {
        public string productCode { get; set; }
        public string packCode { get; set; }
        public decimal fees { get; set; }
        public decimal amount { get; set; }
        public decimal discount { get; set; }
        public DateTime effectDate { get; set; }
    }
}
