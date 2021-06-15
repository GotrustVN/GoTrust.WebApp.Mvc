using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class ActionInfo
    {
        public string ParentCode { get; set; }
        public string UserName { get; set; }
        public string Secret { get; set; }
        public string ActionCode { get; set; }
    }
}
