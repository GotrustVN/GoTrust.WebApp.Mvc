using Microsoft.EntityFrameworkCore;
using Payment.Data.Context;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Repositories
{
    public interface IDistrictRepository
    {
        public District GetById(string id);
    }

    public class DistrictRepository : IDistrictRepository
    {
        private readonly AppDbContext context;

        public DistrictRepository(AppDbContext context)
        {
            this.context = context;
        }

        public District GetById(string id)
        {
            var district = context.District.Include(x => x.wards)
                .FirstOrDefault(x => x.code == id);
            return district;
        }
    }
}
