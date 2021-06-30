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
