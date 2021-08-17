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
    public interface IOrderInforRepository
    {
        public OrderInfor GetByID(string orderId);
    }

    public class OrderInforRepository : IOrderInforRepository
    {
        private readonly AppDbContext context;

        public OrderInforRepository(AppDbContext context)
        {
            this.context = context;
        }

        public OrderInfor GetByID(string orderId)
        {
            var orderInfor = context.OrderInfor.Include(x => x.status)
                .FirstOrDefault(x => x.orderId == orderId);
            return orderInfor;
        }
    }
}
