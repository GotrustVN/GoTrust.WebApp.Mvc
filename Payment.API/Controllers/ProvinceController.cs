using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ProvinceController : ControllerBase
    {
        private readonly IGenericRepository<Province> genericProvinceRepository;
        private readonly IProvinceRepository provinceRepository;
        private readonly AppDbContext context;

        public ProvinceController(IGenericRepository<Province> genericProvinceRepository,
            IProvinceRepository provinceRepository,
            AppDbContext context)
        {
            this.genericProvinceRepository = genericProvinceRepository;
            this.provinceRepository = provinceRepository;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetProvinces()
        {
            var data = genericProvinceRepository.Get();
            return new CommonResponse().SetData(data);
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetProvince(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var province = provinceRepository.GetById(code);
                return new CommonResponse().SetData(province);
            }
            return BadRequest();
        }
    }
}
