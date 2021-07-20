using Payment.Data.Context;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Repositories
{
    public interface IUserRepository
    {
        public bool IsExistUserWithEmail(string email, out User user);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool IsExistUserWithEmail(string email, out User user)
        {
            user = null;
            
            user = context.User.FirstOrDefault(x => x.email == email);

            if (user != null)
                return true;
            return false;
        }
    }
}
