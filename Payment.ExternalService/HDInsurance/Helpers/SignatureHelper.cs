using Payment.SharedUltilities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class SignatureHelper
    {
        public static bool IsValidSignature(string signature, string value, string key)
        {
            string content = SecurityHelper.MD5(value);
            var checkSignature = SecurityHelper.Sha256(content, key);
            
            if (signature == checkSignature)
            {
                return true;
            }

            return false;
        }
    }
}
