using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class VehicleInsuranceVoluntaryCivil
    {
        public int id { get; set; }
        public VehicleInsuranceDetail orderDetail { get; set; }
        public string packCode { get; set; }
        public string insur3rd { get; set; }
        public string insur3rdAssets { get; set; }
        public string insur3rdPassenger { get; set; }
        public string totalLiAbility { get; set; }
        public string driverNum { get; set; }
        public string driverInsur { get; set; }
        public string weightCargo { get; set; }
        public string cargoInsur { get; set; }
    }
}
