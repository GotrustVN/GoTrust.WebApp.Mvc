using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class BankController : ControllerBase
    {
        private readonly IGenericRepository<Bank> genericBankRepository;
        private readonly AppDbContext context;

        public BankController(IGenericRepository<Bank> genericBankRepository,
            AppDbContext context)
        {
            this.genericBankRepository = genericBankRepository;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetBanks()
        {
            var data = genericBankRepository.Get();
            return new CommonResponse()
                .SetResult(new CommonResult()
                {
                    message = "",
                    code = "success"
                })
                .SetData(data);
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetBank(string code)
        {
            var data = genericBankRepository.GetByID(code);
            return new CommonResponse()
                .SetResult(new CommonResult()
                {
                    message = "",
                    code = "success"
                })
                .SetData(data);
        }
    }
}
