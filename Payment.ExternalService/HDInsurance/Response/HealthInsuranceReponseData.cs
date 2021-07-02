using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsuranceReponseData
    {
        public object ORDER_CODE { get; set; }
        public string CONTRACT_CODE { get; set; }
        public string CONTRACT_NO { get; set; }
        public string CONTRACT_MODE { get; set; }
        public string STATUS { get; set; }
        public object STATUS_NAME { get; set; }
        public float AMOUNT { get; set; }
        public float TOTAL_DISCOUNT { get; set; }
        public float VAT { get; set; }
        public float TOTAL_AMOUNT { get; set; }
        public INSURED[] INSURED { get; set; }
        public object CUS_ID { get; set; }
        public string TYPE { get; set; }
        public object FAX { get; set; }
        public object TAXCODE { get; set; }
        public object ADDRESS_FORM { get; set; }
        public object NATIONALITY { get; set; }
        public string NAME { get; set; }
        public string DOB { get; set; }
        public string GENDER { get; set; }
        public object PROV { get; set; }
        public object DIST { get; set; }
        public object WARDS { get; set; }
        public object ADDRESS { get; set; }
        public object IDCARD { get; set; }
        public object IDCARD_D { get; set; }
        public object IDCARD_P { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
    }

    public class INSURED
    {
        public string DETAIL_CODE { get; set; }
        public string CONTRACT_CODE { get; set; }
        public string CERTIFICATE_NO { get; set; }
        public string CATEGORY { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string PACK_CODE { get; set; }
        public string RELATIONSHIP { get; set; }
        public object BENEFICIARY { get; set; }
        public string REGION { get; set; }
        public string EFFECTIVE_DATE { get; set; }
        public string EXPIRATION_DATE { get; set; }
        public object ADDITIONAL { get; set; }
        public float ADDITIONAL_FEES { get; set; }
        public float AMOUNT { get; set; }
        public float TOTAL_DISCOUNT { get; set; }
        public float VAT { get; set; }
        public float TOTAL_AMOUNT { get; set; }
        public string URL_GCN { get; set; }
        public object CUS_ID { get; set; }
        public string TYPE { get; set; }
        public object FAX { get; set; }
        public object TAXCODE { get; set; }
        public object ADDRESS_FORM { get; set; }
        public object NATIONALITY { get; set; }
        public string NAME { get; set; }
        public string DOB { get; set; }
        public string GENDER { get; set; }
        public object PROV { get; set; }
        public object DIST { get; set; }
        public object WARDS { get; set; }
        public object ADDRESS { get; set; }
        public object IDCARD { get; set; }
        public object IDCARD_D { get; set; }
        public object IDCARD_P { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
    }
}
