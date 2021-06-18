using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using Payment.SharedModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MasterCategoryController : ControllerBase
    {
        private readonly IGenericRepository<MasterCategory> genericMasterCategoryRepository;
        private readonly IMasterCategoryRepository masterCategoryRepository;

        public MasterCategoryController(IGenericRepository<MasterCategory> genericMasterCategoryRepository,
            IMasterCategoryRepository masterCategoryRepository)
        {
            this.genericMasterCategoryRepository = genericMasterCategoryRepository;
            this.masterCategoryRepository = masterCategoryRepository;
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetMasterCategories(string group)
        {
            IEnumerable<MasterCategory> data = null;
            if (!string.IsNullOrEmpty(group))
            {
                data = masterCategoryRepository.GetGroupOfCategories(group);
            }
            else
            {
                data = genericMasterCategoryRepository.Get();
            }

            if(data != null &&
               data.Count() > 0)
            {
                return new CommonResponse().SetData(data);
            }
            return NotFound();
        }

        [HttpGet]
        public ActionResult<CommonResponse> GetMasterCategory(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var masterCategory = genericMasterCategoryRepository.GetByID(code);
                if(masterCategory != null)
                {
                    return new CommonResponse().SetData(masterCategory);
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}
