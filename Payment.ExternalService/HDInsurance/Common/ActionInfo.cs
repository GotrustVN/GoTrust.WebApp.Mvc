using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class ActionInfo
    {
        public ActionInfo(string actionCode, bool initDefault = false)
        {
            if (initDefault)
            {
                this.ParentCode = AppGlobal.HDInsurance_Channel;
                this.UserName = AppGlobal.HDInsurance_UserName;
                this.Secret = AppGlobal.HDInsurance_Secret;
                this.ActionCode = actionCode;
            }
        }
        public string ParentCode { get; set; }
        public string UserName { get; set; }
        public string Secret { get; set; }
        public string ActionCode { get; set; }
    }
}
