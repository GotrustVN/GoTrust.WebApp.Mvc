using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class DeviceInfo
    {
        public string DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string IpPrivate { get; set; }
        public string IpPublic { get; set; }
        public string PortPublic { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Wards { get; set; }
        public string Address { get; set; }
        public string Environment { get; set; }
        public string Browser { get; set; }
        public string DeviceEnvironment { get; set; }
    }
}
