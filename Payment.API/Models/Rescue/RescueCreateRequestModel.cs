using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class RescueCreateRequestModel
    {
        public string username { get; set; }
        public string typeCode { get; set; }
        public decimal lat { get; set; }
        public decimal lon { get; set; }
        public string address { get; set; }
        public DateTime? createdAt { get; set; }
        public string description { get; set; }
        public List<RescueThumbnailRequestModel> rescueThumbnails { get; set; }
    }
}
