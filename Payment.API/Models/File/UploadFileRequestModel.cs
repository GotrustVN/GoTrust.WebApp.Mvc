using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class UploadFileRequestModel
    {
        public string username { get; set; }
        public string fileTypeCode { get; set; }
        public IFormFile uploadFile { get; set; }
    }
}
