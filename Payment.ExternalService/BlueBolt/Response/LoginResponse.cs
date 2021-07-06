using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public class LoginResponse
    {
        public int code { get; set; }
        public LoginData data { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }
    public class LoginData
    {
        public string user_name { get; set; }
        public Company_Profile company_profile { get; set; }
        public string role { get; set; }
        public string uuid { get; set; }
        public string token { get; set; }
    }
    public class Company_Profile
    {
        public bool is_worker_company { get; set; }
        public bool is_customer_company { get; set; }
        public string company_code { get; set; }
    }
}
