using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public class LoginRequest
    {
        public LoginRequest(bool initDefault)
        {
            if (initDefault)
            {
                user_name = AppGlobal.BlueBolt_Username;
                password = AppGlobal.BlueBolt_Password;
                company_code = AppGlobal.BlueBolt_Company_Code;
            }
        }
        public string user_name { get; set; }
        public string password { get; set; }
        public string company_code { get; set; }
    }
}
