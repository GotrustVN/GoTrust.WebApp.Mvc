using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public static class BlueBoltGlobal
    {
        public static string requestToken { get; set; }
        public static DateTime lastLoginAt { get; set; }
    }
}
