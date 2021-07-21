using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class RescueThumbnailRequestModel
    {
        public List<IFormFile> images { get; set; }
    }
}
