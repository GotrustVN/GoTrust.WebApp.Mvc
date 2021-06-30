using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using HDIClient.MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IGenericRepository<CustomerType> genericCustomerTypeRepository;
        private readonly IGenericRepository<Gender> genericGenderRepository;
        private readonly IGenericRepository<Customer> genericCustomerRepository;
        private readonly IGenericRepository<Province> genericProvinceRepository;
        private readonly IGenericRepository<District> genericDistrictRepository;
        private readonly IGenericRepository<Ward> genericWardRepository;
        private readonly IGenericRepository<FileImport> genericFileImportRepository;
        private readonly IGenericRepository<FileType> genericFileTypeRepository;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;
        private readonly INotyfService notyf;

        public CustomerController(ILogger<CustomerController> logger,
            IGenericRepository<CustomerType> genericCustomerTypeRepository,
            IGenericRepository<Gender> genericGenderRepository,
            IGenericRepository<Customer> genericCustomerRepository,
            IWebHostEnvironment hostEnvironment,
            ICustomerRepository customerRepository,
            IMapper mapper,
            AppDbContext context,
            INotyfService notyf)
        {
            _logger = logger;
            this.genericCustomerTypeRepository = genericCustomerTypeRepository;
            this.genericGenderRepository = genericGenderRepository;
            this.genericCustomerRepository = genericCustomerRepository;
            this.hostEnvironment = hostEnvironment;
            this.customerRepository = customerRepository;
            this.mapper = mapper;
            this.context = context;
            this.notyf = notyf;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string code)
        {
            var customer = customerRepository.GetById(code, true);

            var model = mapper.Map<CustomerDetailViewModel>(customer);

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

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CustomerDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = mapper.Map<Customer>(model);
                customer.SetDefaultValue();

                if (!genericCustomerTypeRepository.IsExistById(model.typeCode, out CustomerType customerType))
                {
                    notyf.Error("Invalid customer type");
                    return View("~/View/Customer/Detail.cshtml", model);
                }

                customer.type = customerType;

                if (!genericGenderRepository.IsExistById(model.genderCode, out Gender gender))
                {
                    notyf.Error("Invalid customer gender");
                    return View("~/View/Customer/Detail.cshtml", model);
                }

                customer.gender = gender;

                genericCustomerRepository.Update(customer);
                var result = context.SaveChanges();

                if (result > 0)
                {
                    notyf.Success("Cập nhật thông tin thành công!");
                    return View("~/View/Customer/Detail.cshtml", model);
                }
                else
                {
                    notyf.Error("Lưu thay đổi thất bại");
                }
            }
            return View("~/View/Customer/Detail.cshtml", model);
        }
    }
}
