using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class VehicleInsuranceCompulsoryCivil
    {
        public int id { get; set; }
        public VehicleInsuranceDetail orderDetail { get; set; }
        public string packCode { get; set; }
        public bool isSerialNum { get; set; }
        public DateTime effectiveDate { get; set; }
        public DateTime expireDate { get; set; }
    }
}
