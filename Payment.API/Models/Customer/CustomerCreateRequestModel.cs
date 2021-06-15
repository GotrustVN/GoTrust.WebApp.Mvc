using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class CustomerCreateRequestModel
    {
        public string name { get; set; }
        public string typeCode { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string genderCode { get; set; }
        public string provinceCode { get; set; }
        public string districtCode { get; set; }
        public string wardCode { get; set; }
        public string address { get; set; }
        public string fullAddress { get; set; }
        public string identityNumber { get; set; }
        public string identityPlace { get; set; }
        public DateTime identityDate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string taxCode { get; set; }
        public string note { get; set; }
    }
}
