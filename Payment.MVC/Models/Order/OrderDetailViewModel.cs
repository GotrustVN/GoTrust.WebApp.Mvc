﻿using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.MVC.Models
{
    public class OrderDetailViewModel
    {
        public string orderId { get; set; }
        public string orderDescription { get; set; }
        public string orderTypeCode { get; set; }
        public decimal amount { get; set; }
        public string bankCode { get; set; }
        public string languageCode { get; set; }
        public DateTime createdDate { get; set; }

        #region DropDown
        public IEnumerable<OrderType> orderTypes { get; set; }
        public IEnumerable<Bank> banks { get; set; }
        public IEnumerable<Language> languages { get; set; }
        #endregion
    }
}
