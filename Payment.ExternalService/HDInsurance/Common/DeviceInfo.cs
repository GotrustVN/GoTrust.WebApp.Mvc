using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public class DeviceInfo
    {
        public DeviceInfo(bool initDefault = false)
        {
            if (initDefault)
            {
                this.DeviceId = string.Empty;
                this.DeviceCode = string.Empty;
                this.IpPrivate = string.Empty;
                this.IpPublic = string.Empty;
                this.X = string.Empty;
                this.Y = string.Empty;
                this.Province = string.Empty;
                this.District = string.Empty;
                this.Wards = string.Empty;
                this.Address = string.Empty;
                this.Environment = string.Empty;
                this.Browser = string.Empty;
                this.DeviceEnvironment = "WEB";
            }
        }
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
