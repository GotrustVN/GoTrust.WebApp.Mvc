﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class OrderRequestModel
    {
        public string orderDescription { get; set; }
        public string orderTypeCode { get; set; }
        public decimal amount { get; set; }
        public string bankCode { get; set; }
        public string languageCode { get; set; }
        public DateTime createdDate { get; set; }
    }
}
