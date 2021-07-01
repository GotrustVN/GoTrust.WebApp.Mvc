using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class VehicleInsuranceDetail
    {
        public int id { get; set; }
        public VehicleInsuranceOrder order { get; set; }
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerType { get; set; }
        public DateTime customerDateOfBirth { get; set; }
        public string customerGender { get; set; }
        public string customerProvince { get; set; }
        public string customerDistrict { get; set; }
        public string customerWard { get; set; }
        public string customerAddress { get; set; }
        public string customerFullAddress { get; set; }
        public string customerNationality { get; set; }
        public string customerIdentityNumber { get; set; }
        public string customerIdentityPlace { get; set; }
        public DateTime? customerIdentityDate { get; set; }
        public string customerPhone { get; set; }
        public string customerEmail { get; set; }
        public string customerFax { get; set; }
        public string customerTaxCode { get; set; }
        public MasterCategory relationship { get; set; }
        public bool isSplitOrder { get; set; }
        public MasterCategory vehicleGroup { get; set; }
        public MasterCategory vehicleType { get; set; }
        public MasterCategory vehicleUse { get; set; }
        public bool noneNumberPlate { get; set; }
        public MasterCategory seat { get; set; }
        public MasterCategory weighCode { get; set; }
        public string mfg { get; set; }
        public string capacity { get; set; }
        /// <summary>
        /// Giá tham khảo ở thị trường
        /// </summary>
        public string refVehicleValue { get; set; }
        /// <summary>
        /// Ngày đăng ký xe
        /// </summary>
        public string vehicleRegis { get; set; }
        public string numberPlate { get; set; }
        public string chassisNo { get; set; }
        public string engineNo { get; set; }
        public int seatNo { get; set; }
        public string weigh { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public bool isVoluntary { get; set; }
        public bool isDriver { get; set; }
        public bool isCargo { get; set; }
        public bool isCompulsory { get; set; }
        public bool isVoluntaryAll { get; set; }
        public bool isPhysical { get; set; }
    }
}
