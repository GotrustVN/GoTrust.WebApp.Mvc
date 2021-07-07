using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public class BaseResponse
    {
        public int code { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }
}
