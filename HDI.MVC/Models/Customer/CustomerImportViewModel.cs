using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Models
{
    public class CustomerImportViewModel
    {
        public string fileTypeCode { get; set; }
        public IFormFile uploadFile { get; set; }
    }
}
