using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsurance
    {
        public string CUS_ID { get; set; }
        public string TYPE { get; set; }
        public string NATIONALITY { get; set; }
        public string NAME { get; set; }
        public string DOB { get; set; }
        public string GENDER { get; set; }
        public string PROV { get; set; }
        public string DIST { get; set; }
        public string WARDS { get; set; }
        public string ADDRESS { get; set; }
        public string IDCARD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string FAX { get; set; }
        public string TAXCODE { get; set; }
        public string RELATIONSHIP { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string PACK_CODE { get; set; }
        public string REGION { get; set; } = "VN";
        public string EFFECTIVE_DATE { get; set; }
        public string EXPIRATION_DATE { get; set; }
        public string FEES { get; set; }
        public string AMOUNT { get; set; }
        public string TOTAL_DISCOUNT { get; set; }
        public string TOTAL_ADD { get; set; }
        public string VAT { get; set; }
        public string TOTAL_AMOUNT { get; set; }
    }
}
