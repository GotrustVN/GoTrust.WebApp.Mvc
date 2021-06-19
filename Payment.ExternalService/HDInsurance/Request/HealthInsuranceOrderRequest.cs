using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsuranceOrderRequest
    {
        public DeviceInfo Device { get; set; }
        public ActionInfo Action { get; set; }
        public HealthInsuranceData Data { get; set; }
        public PaymentInfo Payment { get; set; }
        public string Signature { get; set; }
        public string Process { get; set; }
    }
}
