using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public static class HDIGlobal
    {
        public static string RequestToken { get; set; }
        public static int TokenExpire { get; set; }
        public static string RefreshToken { get; set; }
        public static DateTime? LastUpdateAt { get; set; }
        public static DateTime? TokenExpireAt
        {
            get
            {
                if(LastUpdateAt != null && TokenExpire > 60)
                {
                    return LastUpdateAt.GetValueOrDefault().AddSeconds(TokenExpire);
                }
                return null;
            }
        }

        public static bool IsTokenExpired
        {
            get
            {
                if (TokenExpireAt != null &&
                    DateTime.Now < TokenExpireAt)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
