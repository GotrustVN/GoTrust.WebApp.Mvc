using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public int Expires { get; set; }
        public string RefeshToken { get; set; }
        public string Signature { get; set; }
        public string GetRawData()
        {
            return "Success=" + Success +
                "Error=" + Error +
                "ErrorMessage=" + ErrorMessage +
                "Token=" + Token +
                "Expries=" + Expires +
                AppGlobal.HDInsurance_Secret;
        }    
    }
}
