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
        public ActionResult<CommonResponse> CreateHealthInsuranceOrder(HealthInsuranceOrderCreateRequestModel request)
        {
            if(ModelState.IsValid)
            {
                var healthInsuranaceOrder = mapper.Map<HealthInsuranceOrder>(request);
                healthInsuranaceOrder.SetDefaultValue();

                if (!genericMasterCategoryRepository.IsExistById(request.categoryCode, out MasterCategory category))
                {
                    ModelState.AddModelError("CategoryCodeError", "Invalid category code");
                    return BadRequest();
                }

                healthInsuranaceOrder.category = category;

                if (!customerRepository.IsValidCustomerCode(request.buyerCode, out Customer customer))
                {
                    ModelState.AddModelError("CustomerCodeError", "Invalid customer code");
                    return BadRequest();
                }

                healthInsuranaceOrder.buyer = customer;
                healthInsuranaceOrder.UpdateBuyerInfor();

                foreach(var detail in request.Details)
                {
                    var healthInsuranceDetail = mapper.Map<HealthInsuranceDetail>(detail);
                    healthInsuranaceOrder.Details.Add(healthInsuranceDetail);
                }

                var payment = mapper.Map<HealthInsurancePayment>(request.payment);
                healthInsuranaceOrder.payment = payment;

                var orderRequest = mapper.Map<HealthInsuranceOrderRequest>(healthInsuranaceOrder);
                orderRequest.SetDefaultData();

                orderRequest.Data.PRODUCT_CODE = healthInsuranaceOrder.productCode;
                orderRequest.Data.CATEGORY = healthInsuranaceOrder.category.code;

                orderRequest.Data.PAY_INFO = new PaymentInfo()
                {
                    PAYMENT_TYPE = healthInsuranaceOrder.payment.paymentType
                };

                foreach(var detail in healthInsuranaceOrder.Details)
                {
                    var healthInsurance = mapper.Map<HealthInsurance>(detail);
                    orderRequest.Data.HEALTH_INSUR.Add(healthInsurance);
                }

                var createResult = hdiService.CreateOrder(orderRequest, out string errorMessage, out HealthInsuranceReponseData reponseData);

                if (!createResult)
                {
                    ModelState.AddModelError("HDI", errorMessage);
                    return BadRequest(ModelState);
                }

                genericHealthInsuranceOrderRepository.Insert(healthInsuranaceOrder);

                var result = context.SaveChanges();

                var response = new CommonResponse();

                if (result > 0)
                {
                    response.GetDeleteSuccessResponse("health insurance")
                        .SetData(healthInsuranaceOrder);
                }
                else
                {
                    response.GetDeleteSuccessResponse("customer insurance")
                        .SetData(healthInsuranaceOrder);
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
