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
    public interface ICustomerRepository
    {
        public bool IsValidCustomerCode(string code, out Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool IsValidCustomerCode(string code, out Customer customer)
        {
            var existCustomer = context.Customer
                .Include(x => x.province)
                .Include(x => x.district)
                .Include(x => x.ward)
                .Include(x => x.type)
                .Include(x => x.gender)
                .FirstOrDefault(x => x.code == code);

            if(existCustomer != null)
            {
                customer = existCustomer;
                return true;
            }
            customer = null;
            return false;
        }
    }
}
