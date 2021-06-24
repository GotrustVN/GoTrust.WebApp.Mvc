using HDI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Controllers
{
    public class ProvinceController : Controller
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceController(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDistricts(string provinceCode)
        {
            var province = provinceRepository.GetById(provinceCode);
            if (province != null)
                return Json(province.districts.Select(x => new DistrictSelectViewModel()
                {
                    id = x.code,
                    text = x.name
                }));
            else
                return Json(new List<DistrictSelectViewModel>());
        }
    }
}
