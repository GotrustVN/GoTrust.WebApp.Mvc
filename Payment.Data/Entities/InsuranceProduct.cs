using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class InsuranceProduct
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string packCode { get; set; }
        public string packName { get; set; }
        public string productDescription { get; set; }
    }
}
