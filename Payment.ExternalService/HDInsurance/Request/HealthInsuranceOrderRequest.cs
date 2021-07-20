using Newtonsoft.Json;
using Payment.SharedUltilities.Global;
using Payment.SharedUltilities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsuranceOrderRequest
    {
        public HealthInsuranceOrderRequest()
        {

        }

        public HealthInsuranceOrderRequest(bool initDefault = false)
        {
            if (initDefault)
            {
                SetDefaultData();
            }
        }

        public DeviceInfo Device { get; set; }
        public ActionInfo Action { get; set; }
        public HealthInsuranceData Data { get; set; }
        public string Signature { get; set; }
        public string Process { get; set; }

        public void CreateSignature()
        {
            string raw = "HDI"
                + this.Device?.DeviceCode
                + this.Device?.IpPrivate
                + this.Device?.DeviceEnvironment
                + AppGlobal.HDInsurance_UserName
                + AppGlobal.HDInsurance_Secret
                + AppGlobal.HDInsurance_ActionCode
                + this.Action?.ParentCode
                + SecurityHelper.MD5(JsonConvert.SerializeObject(Data).ToString()).ToUpper()
                + "HDI";

            string content = SecurityHelper.MD5(raw);
            this.Signature = SecurityHelper.Sha256(content, AppGlobal.HDInsurance_ClientId).ToUpper();
        }

        public void SetDefaultData()
        {
            this.Device = new DeviceInfo(true);
            this.Action = new ActionInfo(AppGlobal.HDInsurance_ActionCode, true);
            if (this.Data == null)
            {
                this.Data = new HealthInsuranceData(true);
            }
            else
            {
                this.Data.CHANNEL = AppGlobal.HDInsurance_Channel;
                this.Data.USERNAME = AppGlobal.HDInsurance_UserName;
                this.Data.SELLER = new SellerInfo(true);
            }
        }
    }
}
