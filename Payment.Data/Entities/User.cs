﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Data.Entities
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string hashkey { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool isActive { get; set; }
        public string customerCode { get; set; }
    }
}
