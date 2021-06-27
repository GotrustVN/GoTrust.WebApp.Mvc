using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsuranceData
    {
        public HealthInsuranceData(bool initDefault = false)
        {
            if (initDefault)
            {
                this.CHANNEL = AppGlobal.HDInsurance_Channel;
                this.USERNAME = AppGlobal.HDInsurance_UserName;
                this.SELLER = new SellerInfo(true);
            }
        }
        public string CHANNEL { get; set; }
        public string USERNAME { get; set; }
        public string ACTION { get; set; }
        public string CATEGORY { get; set; }
        public string PRODUCT_CODE { get; set; }
        public SellerInfo SELLER { get; set; }
        public BuyerInfo BUYER { get; set; }
        public List<HealthInsurance> HEALTH_INSUR { get; set; } = new List<HealthInsurance>();
    }
}
