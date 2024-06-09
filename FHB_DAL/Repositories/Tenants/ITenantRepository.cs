using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Tenants
{
    public interface ITenantRepository : IGenericRepository<Tenant>
    {
        Tenant GetTenantByName( string name);
    }
}
