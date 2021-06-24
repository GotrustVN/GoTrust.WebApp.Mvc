using HDI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IDistrictRepository districtRepository;

        public DistrictController(IDistrictRepository districtRepository)
        {
            this.districtRepository = districtRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetWards(string districtCode)
        {
            var district = districtRepository.GetById(districtCode);
            if (district != null)
                return Json(district.wards.Select(x => new WardSelectViewModel()
                {
                    id = x.code,
                    text = x.name
                }));
            else
                return Json(new List<WardSelectViewModel>());

        }
    }
}
