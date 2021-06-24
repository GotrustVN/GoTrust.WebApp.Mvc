using Microsoft.AspNetCore.Mvc;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Models
{
    public class CustomerDetailViewModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string typeCode { get; set; }
        [BindProperty, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dateOfBirth { get; set; }
        public Gender gender { get; set; }
        public CustomerType type { get; set; }
        public string fullAddress { get; set; }
        public string identityNumber { get; set; }
        public string identityPlace { get; set; }
        [BindProperty, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime identityDate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string taxCode { get; set; }
        public string note { get; set; }
        public string nationality { get; set; }
    }
}
