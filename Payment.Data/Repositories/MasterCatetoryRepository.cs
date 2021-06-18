using Payment.Data.Context;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Repositories
{
    public interface IMasterCategoryRepository
    {
        public IEnumerable<MasterCategory> GetGroupOfCategories(string group);
    }
    public class MasterCatetoryRepository : IMasterCategoryRepository
    {
        private readonly AppDbContext context;

        public MasterCatetoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<MasterCategory> GetGroupOfCategories(string group)
        {
            return context.MasterCategory.Where(x => x.group == group);
        }
    }
}
