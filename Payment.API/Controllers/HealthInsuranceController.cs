using AutoMapper;
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
    public class HealthInsuranceController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly AppDbContext context;
        private readonly IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository;
        private readonly IGenericRepository<HealthInsuranceDetail> genericHealthInsuranceDetailRepository;
        private readonly IGenericRepository<HealthInsurancePayment> genericHealthHealthInsurancePaymentRepository;

        public HealthInsuranceController(IMapper mapper,
            AppDbContext context,
            IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository,
            IGenericRepository<HealthInsuranceDetail> genericHealthInsuranceDetailRepository,
            IGenericRepository<HealthInsurancePayment> genericHealthHealthInsurancePaymentRepository)
        {
            this.mapper = mapper;
            this.context = context;
            this.genericHealthInsuranceOrderRepository = genericHealthInsuranceOrderRepository;
            this.genericHealthInsuranceDetailRepository = genericHealthInsuranceDetailRepository;
            this.genericHealthHealthInsurancePaymentRepository = genericHealthHealthInsurancePaymentRepository;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetHealthInsuranceOrders()
        {
            var data = genericHealthInsuranceOrderRepository.Get(null, null, "Details,payment,category");
            return new CommonResponse().SetData(data);
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetHealthInsuranceOrder(string code)
        {
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CommonResponse> CreateHealthInsuranceOrder(HealthInsuranceOrderCreateRequestModel request)
        {
            if(ModelState.IsValid)
            {
                //TODO: implement logic code
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<CommonResponse> UpdateHealthInsuranceOrder(string code, 
            HealthInsuranceOrderUpdateRequestModel request)
        {
            if(request.code != code)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                //TODO: implement logic code
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult<CommonResponse> DeleteHealthInsuranceOrder(string code)
        {
            //TODO: implement logic code
            return NotFound();
        }
    }
}
