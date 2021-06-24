using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using HDI.MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.MiddleLayer.Processes;
using Payment.SharedModel.Common;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
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

        public CustomerController(ILogger<HomeController> logger,
            IGenericRepository<CustomerType> genericCustomerTypeRepository,
            IGenericRepository<Gender> genericGenderRepository,
            IGenericRepository<Customer> genericCustomerRepository,
            IGenericRepository<Province> genericProvinceRepository,
            IGenericRepository<District> genericDistrictRepository,
            IGenericRepository<Ward> genericWardRepository,
            IGenericRepository<FileImport> genericFileImportRepository,
            IGenericRepository<FileType> genericFileTypeRepository,
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
            this.genericProvinceRepository = genericProvinceRepository;
            this.genericDistrictRepository = genericDistrictRepository;
            this.genericWardRepository = genericWardRepository;
            this.genericFileImportRepository = genericFileImportRepository;
            this.genericFileTypeRepository = genericFileTypeRepository;
            this.hostEnvironment = hostEnvironment;
            this.customerRepository = customerRepository;
            this.mapper = mapper;
            this.context = context;
            this.notyf = notyf;
        }

        public IActionResult GetAll()
        {
            var data = genericCustomerRepository.Get(
                null, null, "type,gender");
            return Json(new CommonResponse().SetData(data));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string code)
        {
            var customer = customerRepository.GetById(code, true);
            var model = mapper.Map<CustomerDetailViewModel>(customer);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CustomerCreateViewModel();
            
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
        public IActionResult Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = mapper.Map<Customer>(model);
                customer.SetDefaultValue();

                if (!genericCustomerTypeRepository.IsExistById(model.typeCode, out CustomerType customerType))
                {
                    notyf.Error("Invalid customer type");
                    return View();
                }

                customer.type = customerType;

                if (!genericGenderRepository.IsExistById(model.genderCode, out Gender gender))
                {
                    notyf.Error("Invalid customer gender");
                    return View();
                }

                customer.gender = gender;

                if (!string.IsNullOrEmpty(model.provinceCode))
                {
                    genericProvinceRepository.IsExistById(model.provinceCode, out Province province);
                    customer.province = province;
                }

                if (!string.IsNullOrEmpty(model.districtCode))
                {
                    genericDistrictRepository.IsExistById(model.districtCode, out District district);
                    customer.district = district;
                }

                if (!string.IsNullOrEmpty(model.wardCode))
                {
                    genericWardRepository.IsExistById(model.wardCode, out Ward ward);
                    customer.ward = ward;
                }

                genericCustomerRepository.Insert(customer);
                var result = context.SaveChanges();

                if(result > 0)
                {
                    notyf.Success("Thêm mới khách hàng thành công!");
                    return RedirectToAction("Edit", "Customer", customer.code);
                }
                else
                {
                    notyf.Error("Lưu thay đổi thất bại");
                }
            }
            return View();
        }

        public IActionResult Edit(string code)
        {
            var customer = customerRepository.GetById(code, true);
            var model = mapper.Map<CustomerEditViewModel>(customer);

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

        public IActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Import()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Import(CustomerImportViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!genericFileTypeRepository.IsExistById(model.fileTypeCode, out FileType fileType))
                {
                    notyf.Error("Invalid file type");
                    return RedirectToAction("Import");
                }

                if (model.uploadFile == null ||
                   model.uploadFile.Length <= 0)
                {
                    notyf.Error("Invalid upload file");
                    return RedirectToAction("Import");
                }

                if (!fileType.allowExtension.Contains(Path.GetExtension(model.uploadFile.FileName)))
                {
                    notyf.Error("Invalid file extension. " + fileType.allowExtension);
                    return View();
                }

                var directory = hostEnvironment.WebRootPath + AppGlobal.DefaultImportUploadDirectory;
                var fileName = model.uploadFile.FileName;

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var filePath = directory
                    + Path.GetFileNameWithoutExtension(fileName)
                    + AppGlobal.DefaultStringCode
                    + Path.GetExtension(fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await model.uploadFile.CopyToAsync(stream);
                }

                var fileImport = new FileImport()
                {
                    code = AppGlobal.DefaultStringCode,
                    fileName = fileName,
                    savePath = filePath,
                    type = fileType,
                };

                genericFileImportRepository.Insert(fileImport);

                bool importResult = ProcessCustomerLib.ImportCustomerData(filePath, context, out List<Customer> insertCustomers,
                    out List<Customer> updateCustomers, out string errorMessage);

                if (importResult)
                {
                    context.Customer.AddRange(insertCustomers);
                    context.Customer.UpdateRange(updateCustomers);
                    context.SaveChanges();
                    notyf.Success("Import success for " + insertCustomers.Count() + " customer");
                }
                else
                {
                    notyf.Error(errorMessage);
                }

            }
            return View();
        }
    }
}
