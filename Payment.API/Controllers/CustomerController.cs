using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Payment.API.Models;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.MiddleLayer.Processes;
using Payment.SharedModel.Common;
using Payment.SharedUltilities.Global;
using System;
using System.Linq;

namespace Payment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IGenericRepository<Customer> genericCustomerRepository;
        private readonly IGenericRepository<User> genericUserRepository;
        private readonly IGenericRepository<CustomerType> genericCustomerTypeRepository;
        private readonly IGenericRepository<Province> genericProvinceRepository;
        private readonly IGenericRepository<District> genericDistrictRepository;
        private readonly IGenericRepository<Gender> genericGenderRepository;
        private readonly IGenericRepository<Ward> genericWardRepository;
        private readonly IUserRepository userRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public CustomerController(IGenericRepository<Customer> genericCustomerRepository,
            IGenericRepository<User> genericUserRepository,
            IGenericRepository<CustomerType> genericCustomerTypeRepository,
            IGenericRepository<Province> genericProvinceRepository,
            IGenericRepository<District> genericDistrictRepository,
            IGenericRepository<Gender> genericGenderRepository,
            IGenericRepository<Ward> genericWardRepository,
            IUserRepository userRepository,
            ICustomerRepository customerRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.genericCustomerRepository = genericCustomerRepository;
            this.genericUserRepository = genericUserRepository;
            this.genericCustomerTypeRepository = genericCustomerTypeRepository;
            this.genericProvinceRepository = genericProvinceRepository;
            this.genericDistrictRepository = genericDistrictRepository;
            this.genericGenderRepository = genericGenderRepository;
            this.genericWardRepository = genericWardRepository;
            this.userRepository = userRepository;
            this.customerRepository = customerRepository;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetCustomers()
        {
            var data = genericCustomerRepository.Get();
            return new CommonResponse().SetData(data);
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetCustomer(string code)
        {
            var data = context.Customer
                .Include(x => x.type)
                .Include(x => x.gender)
                .Include(x => x.province)
                .Include(x => x.district)
                .Include(x => x.ward)
                .FirstOrDefault(x => x.code == code);
            return new CommonResponse().SetData(data);
        }

        [HttpPost]
        public ActionResult<CommonResponse> Create(CustomerCreateRequestModel request)
        {
            if (ModelState.IsValid)
            {
                var customer = mapper.Map<Customer>(request);
                customer.SetDefaultValue();

                if(customerRepository.IsExistCustomerWithEmail(request.email, out Customer existCustomer))
                {
                    ModelState.AddModelError("Email", "Email was used");
                    return BadRequest(ModelState);
                }

                if (!genericCustomerTypeRepository.IsExistById(request.typeCode, out CustomerType customerType))
                {
                    ModelState.AddModelError("CustomerTypeError","Invalid customer type");
                    return BadRequest();
                }

                customer.type = customerType;

                if(!genericGenderRepository.IsExistById(request.genderCode, out Gender gender))
                {
                    ModelState.AddModelError("GenderError", "Invalid customer gender");
                    return BadRequest(ModelState);
                }

                customer.gender = gender;

                if (!string.IsNullOrEmpty(request.provinceCode))
                {
                    genericProvinceRepository.IsExistById(request.provinceCode, out Province province);
                    customer.province = province;
                }
                if (!string.IsNullOrEmpty(request.districtCode))
                {
                    genericDistrictRepository.IsExistById(request.districtCode, out District district);
                    customer.district = district;

                }
                if (!string.IsNullOrEmpty(request.wardCode))
                {
                    genericWardRepository.IsExistById(request.wardCode, out Ward ward);
                    customer.ward = ward;
                }

                customer.SetFullAddress();

                if(userRepository.IsExistUserWithEmail(customer.email, out User user))
                {
                    ProcessCustomerLib.UpdateCustomerForUser(customer, user);
                }

                genericUserRepository.Update(user);
                genericCustomerRepository.Insert(customer);
                var result = context.SaveChanges();

                var response = new CommonResponse();

                if(result > 0)
                {
                    response.GetCreateSuccessResponse("customer")
                        .SetData(customer);
                }
                else
                {
                    response.GetCreateFailedResponse("customer");
                }

                return response;

            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<CommonResponse> Update(string code, CustomerUpdateRequestModel request)
        {
            if(request.code != code)
            {
                if(ModelState.IsValid)
                {
                    var customer = genericCustomerRepository.GetByID(code);

                    if (customer != null)
                    {
                        customer = mapper.Map<Customer>(request);

                        if (!genericCustomerTypeRepository.IsExistById(request.typeCode, out CustomerType customerType))
                        {
                            ModelState.AddModelError("CustomerTypeError", "Invalid customer type");
                            return BadRequest();
                        }

                        customer.type = customerType;

                        if (!genericGenderRepository.IsExistById(request.genderCode, out Gender gender))
                        {
                            ModelState.AddModelError("GenderError", "Invalid customer gender");
                            return BadRequest();
                        }

                        customer.gender = gender;

                        if (!string.IsNullOrEmpty(request.provinceCode))
                        {
                            genericProvinceRepository.IsExistById(request.provinceCode, out Province province);
                            customer.province = province;
                        }
                        if (!string.IsNullOrEmpty(request.districtCode))
                        {
                            genericDistrictRepository.IsExistById(request.districtCode, out District district);
                            customer.district = district;

                        }
                        if (!string.IsNullOrEmpty(request.wardCode))
                        {
                            genericWardRepository.IsExistById(request.wardCode, out Ward ward);
                            customer.ward = ward;
                        }

                        customer.SetFullAddress();

                        genericCustomerRepository.Update(customer);
                        var result = context.SaveChanges();

                        var response = new CommonResponse();

                        if (result > 0)
                        {
                            response.GetUpdateSuccessResponse("customer")
                                .SetData(customer);
                        }
                        else
                        {
                            response.GetUpdateFailedResponse("customer");
                        }

                        return response;

                    }

                    return NotFound();
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult<CommonResponse> Delete(string code)
        {
            var customer = genericCustomerRepository.GetByID(code);

            if (customer != null)
            {
                genericCustomerRepository.Delete(code);
                var result = context.SaveChanges();

                var response = new CommonResponse();

                if (result > 0)
                {
                    response.GetDeleteSuccessResponse("customer")
                        .SetData(customer);
                }
                else
                {
                    response.GetDeleteFailedResponse("customer");
                }

                return response;
            }

            return NotFound();
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetQR(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var customer = genericCustomerRepository.GetByID(code);

                if (customer == null)
                    return NotFound();

                var response = new CommonResponse();

                var qr = ProcessCustomerLib.GenerateQRCode(code, AppGlobal.DefaultLogoDirectory);

                return response.SetData(Convert.ToBase64String(qr));
            }
            else
            {
                ModelState.AddModelError("CustomerCode", "Invalid customer code");
                return BadRequest();
            }
        }
    }
}
