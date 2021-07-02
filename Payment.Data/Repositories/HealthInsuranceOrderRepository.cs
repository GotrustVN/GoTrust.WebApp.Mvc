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
    public interface IHealthInsuranceOrderRepository
    {
        public HealthInsuranceOrder GetById(string id);
    }
    public class HealthInsuranceOrderRepository : IHealthInsuranceOrderRepository
    {
        private readonly AppDbContext context;

        public HealthInsuranceOrderRepository(AppDbContext context)
        {
            this.context = context;
        }

        public HealthInsuranceOrder GetById(string id)
        {
            var order = context.HealthInsuranceOrder
                .Include(x => x.category)
                .Include(x => x.Details)
                .ThenInclude(d =>  d.relationship)
                .FirstOrDefault(x => x.code == id);
            return order;
        }
    }
}
