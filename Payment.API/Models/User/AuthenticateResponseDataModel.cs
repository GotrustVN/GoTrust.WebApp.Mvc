using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class AuthenticateResponseDataModel
    {
        public string username { get; set; }
        public string customerCode { get; set; }
        public string accessToken { get; set; }
    }
}
