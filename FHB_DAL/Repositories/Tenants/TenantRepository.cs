using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Tenants
{
    public class TenantRepository : GenericRepository<Tenant>, ITenantRepository
    {
        public TenantRepository(FithubDbContext fithubDbContext) : base(fithubDbContext)
        {
        }

        public Tenant GetTenantByName(string name)
        {
            var result = _dbSet.Where(x => x.TenantName == name).FirstOrDefault();
            return result;
        }
    }
}
