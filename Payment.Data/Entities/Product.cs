using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public decimal fee { get; set; }
        public decimal vat { get; set; }
        public decimal discount { get; set; }
        public decimal amount { get; set; }
    }
}
