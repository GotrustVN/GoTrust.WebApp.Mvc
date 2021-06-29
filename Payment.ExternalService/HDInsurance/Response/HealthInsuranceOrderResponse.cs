using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Payment.ExternalService.HDInsurance
{
    public class HealthInsuranceOrderResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string ErrorMessage { get; set; }
        public string Signature { get; set; }
        public object Data { get; set; }
    }
}
