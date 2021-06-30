using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.Models
{
    public class CustomerDetailViewModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string typeCode { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; } = DateTime.Now;
        public string genderCode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public IEnumerable<CustomerTypeSelectViewModel> customerTypes { get; set; } = new List<CustomerTypeSelectViewModel>();
        public IEnumerable<GenderSelectViewModel> genders { get; set; } = new List<GenderSelectViewModel>();
    }
}
