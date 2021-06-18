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
    public interface IProvinceRepository
    {
        public Province GetById(string id);
    }
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly AppDbContext context;

        public ProvinceRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Province GetById(string id)
        {
            var data = context.Province.Include(x => x.districts).ThenInclude(d => d.wards)
                .FirstOrDefault(x => x.code == id);
            return data;
        }
    }
}
