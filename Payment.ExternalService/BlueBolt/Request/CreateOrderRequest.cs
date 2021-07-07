using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public class CreateOrderRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public string country_code { get; set; }
        public string customer_phone { get; set; }
        public string customer_address { get; set; }
        public string customer_name { get; set; }
        public Region city { get; set; }
        public Region district { get; set; }
        public Region ward { get; set; }
        public DateTime end_time { get; set; }
        public string external_id { get; set; }
        public List<Image> images { get; set; }
        public bool is_paid { get; set; }
        public string priority { get; set; }
        public string service { get; set; }
        public string status { get; set; }
    }
}
