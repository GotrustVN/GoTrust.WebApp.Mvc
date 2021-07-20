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
        bool IsValidCustomerCode(string code, out Customer customer);
        bool IsExistCustomerWithEmail(string email, out Customer customer);
        Customer GetById(string id, bool includeAll = false);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Customer GetById(string id, bool includeAll = false)
        {
            if (includeAll)
            {
                return context.Customer
                    .Include(x => x.type)
                    .Include(x => x.gender)
                    .Include(x => x.province)
                    .Include(x => x.district)
                    .Include(x => x.ward)
                    .FirstOrDefault(x => x.code == id);
            }
            else
            {
                return context.Customer.Find(id);
            }
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

        public bool IsExistCustomerWithEmail(string email, out Customer customer)
        {
            customer = null;
            customer = context.Customer.FirstOrDefault(c => c.email == email);

            if(customer != null)
            {
                return true;
            }
            return false;
        }
    }
}
