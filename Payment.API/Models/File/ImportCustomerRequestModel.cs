using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class ImportCustomerRequestModel
    {
        public IFormFile uploadFile { get; set; }
    }
}
