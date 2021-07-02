using AutoMapper;
using HDIClient.MVC.Models;
using Microsoft.AspNetCore.Mvc;
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

namespace HDIClient.MVC.Controllers
{
    public class HealthInsuranceOrderController : Controller
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IGenericRepository<MasterCategory> genericMasterCategoryRepository;
        private readonly IMasterCategoryRepository masterCategoryRepository;
        private readonly IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository;
        private readonly IHealthInsuranceOrderRepository healthInsuranceOrderRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;
        private readonly IHDIService hdiService;

        public HealthInsuranceOrderController(ICustomerRepository customerRepository,
            IGenericRepository<MasterCategory> genericMasterCategoryRepository,
            IMasterCategoryRepository masterCategoryRepository,
            IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository,
            IHealthInsuranceOrderRepository healthInsuranceOrderRepository,
            IMapper mapper,
            AppDbContext context,
            IHDIService hdiService)
        {
            this.customerRepository = customerRepository;
            this.genericMasterCategoryRepository = genericMasterCategoryRepository;
            this.masterCategoryRepository = masterCategoryRepository;
            this.genericHealthInsuranceOrderRepository = genericHealthInsuranceOrderRepository;
            this.healthInsuranceOrderRepository = healthInsuranceOrderRepository;
            this.mapper = mapper;
            this.context = context;
            this.hdiService = hdiService;
        }
        public IActionResult Create(string customerCode, string categoryCode)
        {
            var customer = customerRepository.GetById(customerCode, true);

            var model = new HealthInsuranceOrderCreateViewModel()
            {
                categoryCode = categoryCode,
                buyerCode = customerCode,
                buyerName = customer.name,
                buyerPhone = customer.phone,
                buyerEmail = customer.email,
                buyerType = customer.type.code,
                buyerGender = customer.gender.code,
                buyerDateOfBirth = customer.dateOfBirth
            };

            return View(model);
        }

        public IActionResult DetailPartial(HealthInsuranceDetailViewModel model)
        {
            model.relationships = masterCategoryRepository.GetGroupOfCategories("QUAN_HE_NGUOI_MUA")
                .Select(x => new RelationshipSelectViewModel()
                {
                    id = x.code,
                    text = x.description
                });

            model.products = masterCategoryRepository.GetGroupOfCategories("PRODUCT_CODE")
                .Select(x => new ProductSelectViewModel()
                {
                    id = x.code,
                    text = x.description
                });

            return PartialView(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<CommonResponse> Create(HealthInsuranceOrderCreateViewModel model)
        {
            ModelState.Remove("buyerIndentityDate");

            foreach (var key in ModelState.Keys.Where(m => m.Contains("customerIdentityDate")).ToList())
                ModelState.Remove(key);

            if (ModelState.IsValid)
            {
                var healthInsuranceOrder = mapper.Map<HealthInsuranceOrder>(model);
                healthInsuranceOrder.SetDefaultValue();

                if (!genericMasterCategoryRepository.IsExistById(model.categoryCode, out MasterCategory category))
                {
                    return View(model);
                }

                healthInsuranceOrder.category = category;

                if (!customerRepository.IsValidCustomerCode(model.buyerCode, out Customer customer))
                {
                    ModelState.AddModelError("","Invalid customer code");
                    return View(model);
                }

                healthInsuranceOrder.buyer = customer;
                healthInsuranceOrder.UpdateBuyerInfor();

                foreach (var detail in model.details)
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

                var respone = new CommonResponse();

                if(result > 0)
                {
                    respone.GetCreateSuccessResponse();
                    respone.SetData(healthInsuranceOrder);
                }
                else
                {
                    respone.GetCreateFailedResponse();
                }
                return Json(respone);
            }
            return Json(new CommonResponse().GetCreateFailedResponse());
        }

        [HttpPost]
        public IActionResult Payment(string orderCode)
        {
            return View();
        }

        public IActionResult Detail(string orderCode)
        {
            var order = healthInsuranceOrderRepository.GetById(orderCode);
            var model = new HealthInsuranceOrderDetailViewModel();
            model = mapper.Map<HealthInsuranceOrderDetailViewModel>(order);
            model.details = order.Details.ToList();
            return View(model);
        }

        public IActionResult SendAfterPaid(string orderCode)
        {
            var healthInsuranceOrder = healthInsuranceOrderRepository.GetById(orderCode);

            if(healthInsuranceOrder != null)
            {
                var orderRequest = mapper.Map<HealthInsuranceOrderRequest>(healthInsuranceOrder);
                orderRequest.SetDefaultData();

                orderRequest.Data.PRODUCT_CODE = healthInsuranceOrder.productCode;
                orderRequest.Data.CATEGORY = healthInsuranceOrder.category.code;

                orderRequest.Data.PAY_INFO = new PaymentInfo()
                {
                    PAYMENT_TYPE = "TH"
                };

                foreach (var detail in healthInsuranceOrder.Details)
                {
                    var healthInsurance = mapper.Map<HealthInsurance>(detail);
                    orderRequest.Data.HEALTH_INSUR.Add(healthInsurance);
                }

                var result = hdiService.CreateOrder(orderRequest, out string errorMessage, 
                    out HealthInsuranceReponseData data);

                if (result)
                {
                    healthInsuranceOrder.contractCode = data.CONTRACT_CODE;
                    healthInsuranceOrder.contractNo = data.CONTRACT_NO;
                    healthInsuranceOrder.contractModel = data.CONTRACT_MODE;

                    foreach(var detail in healthInsuranceOrder.Details)
                    {
                        var responseDetail = data.INSURED
                            .FirstOrDefault(x => x.NAME == detail.customerName &&
                                                 x.EMAIL == detail.customerEmail &&
                                                 x.DOB == detail.customerDateOfBirth.ToString("dd/MM/yyyy") &&
                                                 x.PHONE == detail.customerPhone);
                        if(responseDetail != null)
                        {
                            detail.urlGCN = responseDetail.URL_GCN;
                        }
                    }

                    context.SaveChanges();

                    return RedirectToAction("Detail", "HealthInsuranceOrder", new { orderCode = orderCode });
                }
            }

            return View();
        }
    }
}
