using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.SharedUltilities.Global
{
    public class AppGlobal
    {
        #region Default Value
        public static string DefaultStringCode => DateTime.Now.Ticks.ToString();
        public static string DefaultOrderStatusCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultOrderStatusCode").Value;
            }
        }
        public static string DefaultPaymentSuccessMessage
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultPaymentSuccessMessage").Value;
            }
        }
        public static string DefaultInvalidSignatureMessage
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultInvalidSignatureMessage").Value;
            }
        }
        public static string PaymentSuccessOrderStatusCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("PaymentSuccessOrderStatusCode").Value;
            }
        }
        public static string PaymentFailOrderStatusCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("PaymentFailOrderStatusCode").Value;
            }
        }
        public static string DefaultFileUploadDirectory
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultFileUploadDirectory").Value;
            }
        }
        public static string DefaultImageUploadDirectory
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultImageUploadDirectory").Value;
            }
        }
        public static string DefaultImportUploadDirectory
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultImportUploadDirectory").Value;
            }
        }
        public static string DefaultCustomerDetailRequestUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultCustomerDetailRequestUrl").Value;
            }
        }
        public static string DefaultLogoDirectory
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Defaults")
                    .GetSection("DefaultLogoDirectory").Value;
            }
        }
        #endregion

        #region VNPay
        public static string VNP_ReturnUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_ReturnUrl").Value;
            }
        }
        public static string VNP_Url
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_Url").Value;
            }
        }
        public static string VNP_TMNCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_TMNCode").Value;
            }
        }
        public static string VNP_HashSecret
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_HashSecret").Value;
            }
        }
        public static string VNP_Version
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_Version").Value;
            }
        }
        public static string VNP_CurrCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("VNPay")
                    .GetSection("VNP_CurrCode").Value;
            }
        }
        #endregion

        #region HDInsurance
        public static string HDInsurance_Url
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_Url").Value;
            }
        }
        public static string HDInsurance_Secret
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_Secret").Value;
            }
        }
        public static string HDInsurance_UserName
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_UserName").Value;
            }
        }
        public static string HDInsurance_Password
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_Password").Value;
            }
        }
        public static string HDInsurance_ActionCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_ActionCode").Value;
            }
        }
        public static string HDInsurance_ClientId
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_ClientId").Value;
            }
        }
        public static string HDInsurance_Channel
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDInsurance_Channel").Value;
            }
        }
        public static string HDILongIn_ActionCode
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("HDInsurance")
                    .GetSection("HDILongIn_ActionCode").Value;
            }
        }
        #endregion

        #region Blue Bolt
        public static string BlueBolt_BaseUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("BlueBolt")
                    .GetSection("BlueBolt_BaseUrl").Value;
            }
        }

        public static string BlueBolt_Username
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("BlueBolt")
                    .GetSection("BlueBolt_Username").Value;
            }
        }

        public static string BlueBolt_Password
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("BlueBolt")
                    .GetSection("BlueBolt_Password").Value;
            }
        }

        public static string BlueBolt_Company_Code
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("BlueBolt")
                    .GetSection("BlueBolt_Company_Code").Value;
            }
        }
        #endregion
    }
}
