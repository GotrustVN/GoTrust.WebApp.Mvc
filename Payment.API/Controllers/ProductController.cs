using AutoMapper;
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
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> genericProductRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public ProductController(IGenericRepository<Product> genericProductRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.genericProductRepository = genericProductRepository;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetProducts()
        {
            var data = genericProductRepository.Get();
            return new CommonResponse().SetResult(new CommonResult()
            {
                code = "success",
                message = ""
            }).SetData(data);
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetProduct(string code)
        {
            var product = genericProductRepository.GetByID(code);
            return new CommonResponse().SetResult(new CommonResult()
            {
                code = "success",
                message = ""
            }).SetData(product);
        }
    }
}
