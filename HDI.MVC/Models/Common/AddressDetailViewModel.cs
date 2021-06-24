using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Models
{
    public class AddressDetailViewModel
    {
        public string provinceCode { get; set; }
        public string districtCode { get; set; }
        public string wardCode { get; set; }
        public string address { get; set; }
        public string fullAddress { get; set; }
        public IEnumerable<ProvinceSelectViewModel> provinces { get; set; } = new List<ProvinceSelectViewModel>();
        public IEnumerable<DistrictSelectViewModel> districts { get; set; } = new List<DistrictSelectViewModel>();
        public IEnumerable<WardSelectViewModel> wards { get; set; } = new List<WardSelectViewModel>();

    }
}
