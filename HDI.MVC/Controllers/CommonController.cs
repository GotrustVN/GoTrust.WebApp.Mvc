using HDI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Controllers
{
    public class CommonController : Controller
    {
        private readonly IGenericRepository<Province> genericProvinceRepository;
        private readonly IProvinceRepository provinceRepository;
        private readonly IDistrictRepository districtRepository;
        private readonly IMasterCategoryRepository masterCategoryRepository;

        public CommonController(IGenericRepository<Province> genericProvinceRepository,
            IProvinceRepository provinceRepository,
            IDistrictRepository districtRepository,
            IMasterCategoryRepository masterCategoryRepository)
        {
            this.genericProvinceRepository = genericProvinceRepository;
            this.provinceRepository = provinceRepository;
            this.districtRepository = districtRepository;
            this.masterCategoryRepository = masterCategoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Address(AddressDetailViewModel model)
        {
            model.provinces = genericProvinceRepository.Get().Select(x => new ProvinceSelectViewModel()
            {
                id = x.code,
                text = x.name
            });

            if (!string.IsNullOrEmpty(model.districtCode))
            {
                model.districts = provinceRepository.GetById(model.provinceCode)
                    .districts.Select(x => new DistrictSelectViewModel()
                    {
                        id = x.code,
                        text = x.name
                    });
            }

            if (!string.IsNullOrEmpty(model.wardCode))
            {
                model.wards = districtRepository.GetById(model.districtCode)
                    .wards.Select(x => new WardSelectViewModel()
                    {
                        id = x.code,
                        text = x.name
                    });
            }

            return PartialView(model);
        }

    }
}
