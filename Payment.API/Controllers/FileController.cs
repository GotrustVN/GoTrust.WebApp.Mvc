using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.API.Models;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using Payment.SharedModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IGenericRepository<FileImport> genericFileImportRepository;
        private readonly AppDbContext context;

        public FileController(IGenericRepository<FileImport> genericFileImportRepository,
            AppDbContext context)
        {
            this.genericFileImportRepository = genericFileImportRepository;
            this.context = context;
        }

        [HttpPost]
        public ActionResult<CommonResponse> ImportCustomer(ImportCustomerRequestModel request)
        {
            if(request.uploadFile != null)
            {

            }
            return BadRequest();
        }
    }
}
