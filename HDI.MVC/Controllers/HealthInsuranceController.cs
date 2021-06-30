using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using HDI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.ExternalService.HDInsurance;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Controllers
{
    public class HealthInsuranceController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IGenericRepository<CustomerType> genericCustomerTypeRepository;
        private readonly IGenericRepository<Gender> genericGenderRepository;
        private readonly IMasterCategoryRepository masterCategoryRepository;
        private readonly IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository;
        private readonly IGenericRepository<HealthInsuranceDetail> genericHealthInsuranceDetailRepository;
        private readonly IGenericRepository<HealthInsurancePayment> genericHealthHealthInsurancePaymentRepository;
        private readonly IGenericRepository<MasterCategory> genericMasterCategoryRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        private readonly INotyfService notyf;
        private readonly IHDIService hdiService;

        public HealthInsuranceController(ILogger<HomeController> logger,
            IGenericRepository<CustomerType> genericCustomerTypeRepository,
            IGenericRepository<Gender> genericGenderRepository,
            IMasterCategoryRepository masterCategoryRepository,
            IGenericRepository<HealthInsuranceOrder> genericHealthInsuranceOrderRepository,
            IGenericRepository<HealthInsuranceDetail> genericHealthInsuranceDetailRepository,
            IGenericRepository<HealthInsurancePayment> genericHealthHealthInsurancePaymentRepository,
            IGenericRepository<MasterCategory> genericMasterCategoryRepository,
            ICustomerRepository customerRepository,
            AppDbContext context,
            IMapper mapper,
            INotyfService notyf,
            IHDIService hdiService)
        {
            this.logger = logger;
            this.genericCustomerTypeRepository = genericCustomerTypeRepository;
            this.genericGenderRepository = genericGenderRepository;
            this.masterCategoryRepository = masterCategoryRepository;
            this.genericHealthInsuranceOrderRepository = genericHealthInsuranceOrderRepository;
            this.genericHealthInsuranceDetailRepository = genericHealthInsuranceDetailRepository;
            this.genericHealthHealthInsurancePaymentRepository = genericHealthHealthInsurancePaymentRepository;
            this.genericMasterCategoryRepository = genericMasterCategoryRepository;
            this.customerRepository = customerRepository;
            this.context = context;
            this.mapper = mapper;
            this.notyf = notyf;
            this.hdiService = hdiService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string code)
        {

            return View();
        }

        [HttpGet]
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

        [HttpGet]
        public IActionResult Create(string categoryCode)
        {
            var model = new HealthInsuranceOrderCreateViewModel();
            model.categoryCode = categoryCode;

            model.customerTypes = genericCustomerTypeRepository.Get()
                .Select(x => new CustomerTypeSelectViewModel()
                {
                    code = x.code,
                    name = x.name
                });
            model.genders = genericGenderRepository.Get()
                .Select(x => new GenderSelectViewModel()
                {
                    code = x.code,
                    name = x.name
                });

            model.payments = masterCategoryRepository.GetGroupOfCategories("THANH_TOAN")
                .Select(x => new PaymentTypeSelectViewModel() 
                {
                    id = x.code,
                    text = x.description
                });

            return View(model);
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
                    notyf.Error("Invalid category code");
                    return View(model);
                }

                healthInsuranaceOrder.category = category;

                if (!customerRepository.IsValidCustomerCode(model.buyerCode, out Customer customer))
                {
                    notyf.Error("Invalid customer code");
                    return View(model);
                }

                healthInsuranaceOrder.buyer = customer;
                healthInsuranaceOrder.UpdateBuyerInfor();

                foreach (var detail in model.details)
                {
                    var healthInsuranceDetail = mapper.Map<HealthInsuranceDetail>(detail);

                    if(genericMasterCategoryRepository.IsExistById(detail.relationshipCode, 
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
                    ModelState.AddModelError("","Create failed. Internal error");
                }
            }
            return View(model);
        }
    }
}
