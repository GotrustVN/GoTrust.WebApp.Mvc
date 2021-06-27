using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class SellerInfo
    {
        public SellerInfo(bool initDefault = false)
        {
            if (initDefault)
            {
                SELLER_CODE = "";
                ORG_CODE = "";
                ORG_TRAFFIC = "";
                TRAFFIC_LINK = "";
                ENVIROMENT = "WEB";
            }
        }

        public string SELLER_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string ENVIROMENT { get; set; }
        public string ORG_TRAFFIC { get; set; }
        public string TRAFFIC_LINK { get; set; }
    }
}
