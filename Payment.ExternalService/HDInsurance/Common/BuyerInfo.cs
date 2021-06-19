using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class BuyerInfo
    {
        public string CUS_ID { get; set; }
        public string TYPE { get; set; }
        public string NATIONALITY { get; set; }
        public string NAME { get; set; }
        public DateTime? DOB { get; set; }
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
    }
}
