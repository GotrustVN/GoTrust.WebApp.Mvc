using AutoMapper;
using HDIClient.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.ExternalService.HDInsurance;
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
        private readonly IMapper mapper;

        public HealthInsuranceOrderController(ICustomerRepository customerRepository,
            IGenericRepository<MasterCategory> genericMasterCategoryRepository,
            IMasterCategoryRepository masterCategoryRepository,
            IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.genericMasterCategoryRepository = genericMasterCategoryRepository;
            this.masterCategoryRepository = masterCategoryRepository;
            this.mapper = mapper;
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
        public IActionResult Create(HealthInsuranceOrderCreateViewModel model)
        {
            ModelState.Remove("buyerIndentityDate");

            foreach (var key in ModelState.Keys.Where(m => m.Contains("customerIdentityDate")).ToList())
                ModelState.Remove(key);

            if (ModelState.IsValid)
            {
                var healthInsuranaceOrder = mapper.Map<HealthInsuranceOrder>(model);
                healthInsuranaceOrder.SetDefaultValue();

                if (!genericMasterCategoryRepository.IsExistById(model.categoryCode, out MasterCategory category))
                {
                    return View(model);
                }

                healthInsuranaceOrder.category = category;

                if (!customerRepository.IsValidCustomerCode(model.buyerCode, out Customer customer))
                {
                    ModelState.AddModelError("","Invalid customer code");
                    return View(model);
                }

                healthInsuranaceOrder.buyer = customer;
                healthInsuranaceOrder.UpdateBuyerInfor();

                foreach (var detail in model.details)
                {
                    var healthInsuranceDetail = mapper.Map<HealthInsuranceDetail>(detail);

                    if (genericMasterCategoryRepository.IsExistById(detail.relationshipCode,
                        out MasterCategory relationship))
                    {
                        healthInsuranceDetail.relationship = relationship;
                    }

                    if (healthInsuranaceOrder.Details == null)
                        healthInsuranaceOrder.Details = new List<HealthInsuranceDetail>();

                    healthInsuranaceOrder.Details.Add(healthInsuranceDetail);
                }

                var payment = mapper.Map<HealthInsurancePayment>(model.payment);

                healthInsuranaceOrder.payment = payment;

                var orderRequest = mapper.Map<HealthInsuranceOrderRequest>(healthInsuranaceOrder);
                orderRequest.SetDefaultData();

                orderRequest.Data.PRODUCT_CODE = healthInsuranaceOrder.productCode;
                orderRequest.Data.CATEGORY = healthInsuranaceOrder.category.code;

                orderRequest.Data.PAY_INFO = new PaymentInfo()
                {
                    PAYMENT_TYPE = healthInsuranaceOrder.payment.paymentType
                };

                foreach (var detail in healthInsuranaceOrder.Details)
                {
                    var healthInsurance = mapper.Map<HealthInsurance>(detail);
                    orderRequest.Data.HEALTH_INSUR.Add(healthInsurance);
                }

                var createResult = hdiService.CreateOrder(orderRequest, out string errorMessage);

                if (!createResult)
                {
                    notyf.Error(errorMessage);
                    return View(model);
                }

                genericHealthInsuranceOrderRepository.Insert(healthInsuranaceOrder);

                var result = context.SaveChanges();

                if (result > 0)
                {
                    notyf.Success("Thao tác thành công");
                    return RedirectToAction("Detail", "HealthInsurance", new { code = healthInsuranaceOrder.code });
                }
                else
                {
                    ModelState.AddModelError("", "Create failed. Internal error");
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Payment(string orderCode)
        {
            return View();
        }
    }
}
