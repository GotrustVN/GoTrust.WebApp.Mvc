using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class VehicleInsurancePayment
    {
        public string type { get; set; }
        public bool isSMS { get; set; }
        public bool isEmail { get; set; }
    }
}
