using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.API.Models;
using Payment.Data.Context;
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
    public class RescueController : ControllerBase
    {
        private readonly IGenericRepository<Rescue> genericRescueRepository;
        private readonly IGenericRepository<RescueType> genericRescueTypeRepository;
        private readonly IGenericRepository<RescueThumbnail> genericRescueThumbnailRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public RescueController(IGenericRepository<Rescue> genericRescueRepository,
            IGenericRepository<RescueType> genericRescueTypeRepository,
            IGenericRepository<RescueThumbnail> genericRescueThumbnailRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.genericRescueRepository = genericRescueRepository;
            this.genericRescueTypeRepository = genericRescueTypeRepository;
            this.genericRescueThumbnailRepository = genericRescueThumbnailRepository;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpPost]
        public ActionResult<CommonResponse> Create([FromForm]RescueCreateRequestModel request)
        {
            return new CommonResponse();
        }
    }
}
