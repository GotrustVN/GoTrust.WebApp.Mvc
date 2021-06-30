﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.Models
{
    public class HealthInsuranceDetailViewModel
    {
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
        public string productCode { get; set; }
        public string packCode { get; set; }
        public string relationshipCode { get; set; }
        public string region { get; set; }
        [DataType(DataType.Date)]
        public DateTime effectiveDate { get; set; } = DateTime.Now.AddDays(1);
        [DataType(DataType.Date)]
        public DateTime expirationDate { get; set; } = DateTime.Now.AddDays(1).AddYears(1);
        public decimal fees { get; set; }
        public decimal discount { get; set; }
        public decimal amount { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal totalAdd { get; set; }
        public decimal vat { get; set; }
        public decimal totalAmount { get; set; }

        #region select data
        public IEnumerable<RelationshipSelectViewModel> relationships { get; set; } = new List<RelationshipSelectViewModel>();
        public IEnumerable<ProductSelectViewModel> products { get; set; } = new List<ProductSelectViewModel>();
        #endregion
    }
}
