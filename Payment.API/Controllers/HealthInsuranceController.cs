using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.API.Models;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.ExternalService.HDInsurance;
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
        private readonly IGenericRepository<Customer> genericCustomerRepository;
        private readonly IGenericRepository<MasterCategory> genericMasterCategoryRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IHDIService hdiService;

        public HealthInsuranceController(IMapper mapper,
            AppDbContext context,
            IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository,
            IGenericRepository<HealthInsuranceDetail> genericHealthInsuranceDetailRepository,
            IGenericRepository<HealthInsurancePayment> genericHealthHealthInsurancePaymentRepository,
            IGenericRepository<Customer> genericCustomerRepository,
            IGenericRepository<MasterCategory> genericMasterCategoryRepository,
            ICustomerRepository customerRepository,
            IHDIService hdiService)
        {
            this.mapper = mapper;
            this.context = context;
            this.genericHealthInsuranceOrderRepository = genericHealthInsuranceOrderRepository;
            this.genericHealthInsuranceDetailRepository = genericHealthInsuranceDetailRepository;
            this.genericHealthHealthInsurancePaymentRepository = genericHealthHealthInsurancePaymentRepository;
            this.genericCustomerRepository = genericCustomerRepository;
            this.genericMasterCategoryRepository = genericMasterCategoryRepository;
            this.customerRepository = customerRepository;
            this.hdiService = hdiService;
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
        public ActionResult<CommonResponse> CreateHealthInsuranceOrder([FromBody]HealthInsuranceOrderCreateRequestModel request)
        {
            ModelState.Remove("buyerIndentityDate");

            foreach (var key in ModelState.Keys.Where(m => m.Contains("customerIdentityDate")).ToList())
                ModelState.Remove(key);

            if (ModelState.IsValid)
            {
                var healthInsuranceOrder = mapper.Map<HealthInsuranceOrder>(request);
                healthInsuranceOrder.SetDefaultValue();

                if (!genericMasterCategoryRepository.IsExistById(request.categoryCode, out MasterCategory category))
                {
                    ModelState.AddModelError("CategoryCodeError", "Invalid category code");
                    return BadRequest();
                }

                healthInsuranceOrder.category = category;

                if (!customerRepository.IsValidCustomerCode(request.buyerCode, out Customer customer))
                {
                    ModelState.AddModelError("CustomerCodeError", "Invalid customer code");
                    return BadRequest();
                }

                healthInsuranceOrder.buyer = customer;
                healthInsuranceOrder.UpdateBuyerInfor();

                foreach (var detail in request.Details)
                {
                    var healthInsuranceDetail = mapper.Map<HealthInsuranceDetail>(detail);

                    if (genericMasterCategoryRepository.IsExistById(detail.relationshipCode,
                        out MasterCategory relationship))
                    {
                        healthInsuranceDetail.relationship = relationship;
                    }

                    if (healthInsuranceOrder.Details == null)
                        healthInsuranceOrder.Details = new List<HealthInsuranceDetail>();
                    healthInsuranceOrder.Details.Add(healthInsuranceDetail);
                }

                healthInsuranceOrder.totalAmount = healthInsuranceOrder.Details.Sum(x => x.totalAmount);
                genericHealthInsuranceOrderRepository.Insert(healthInsuranceOrder);

                var result = context.SaveChanges();

                var response = new CommonResponse();

                if (result > 0)
                {
                    response.GetDeleteSuccessResponse("health insurance")
                        .SetData(healthInsuranceOrder);
                }
                else
                {
                    response.GetDeleteSuccessResponse("health insurance")
                        .SetData(healthInsuranceOrder);
                }

                return response;

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
