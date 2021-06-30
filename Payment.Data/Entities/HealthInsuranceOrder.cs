using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class HealthInsuranceOrder
    {
        #region contract infor
        public string orderCode { get; set; }
        public string contractCode { get; set; }
        public string contractNo { get; set; }
        public string contractModel { get; set; }
        public string status { get; set; }
        public string statusName { get; set; }
        public decimal amount { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal vat { get; set; }
        public decimal totalAmount { get; set; }
        #endregion
        
        public string code { get; set; }
        public string channel { get; set; }
        public string username { get; set; }
        public string action { get; set; }
        public MasterCategory category { get; set; }
        public string productCode { get; set; }
        public Customer buyer { get; set; }
        
        #region Customer Infor clone
        public string buyerCode { get; set; }
        public string buyerName { get; set; }
        public string buyerType { get; set; }
        public DateTime buyerDateOfBirth { get; set; }
        public string buyerGender { get; set; }
        public string buyerProvince { get; set; }
        public string buyerDistrict { get; set; }
        public string buyerWard { get; set; }
        public string buyerAddress { get; set; }
        public string buyerFullAddress { get; set; }
        public string buyerNationality { get; set; }
        public string buyerIdentityNumber { get; set; }
        public string buyerIdentityPlace { get; set; }
        public DateTime? buyerIdentityDate { get; set; }
        public string buyerPhone { get; set; }
        public string buyerEmail { get; set; }
        public string buyerFax { get; set; }
        public string buyerTaxCode { get; set; }
        #endregion

        public HealthInsurancePayment payment { get; set; }

        public virtual ICollection<HealthInsuranceDetail> Details { get; set; }
    }
}
