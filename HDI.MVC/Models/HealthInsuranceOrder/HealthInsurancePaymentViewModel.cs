using System;

namespace HDI.MVC.Models
{
    public class HealthInsurancePaymentViewModel
    {
        public string paymentType { get; set; }
        public DateTime payementDate { get; set; } = DateTime.Now;
    }
}