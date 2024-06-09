using AutoMapper;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Tenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.TenantServices
{
    
public class TenantService: GenericService<Tenant,TenantDto>,ITenantService
    {
        public readonly ITenantRepository _tenantRepository;
        public readonly IMapper _mapper;

        public TenantService (ITenantRepository tenantRepository, IMapper mapper):base(tenantRepository, mapper)
        {
            _tenantRepository = tenantRepository;
            _mapper = mapper;
        }

        public ApiResponse<TenantDto> GetTenantByName(string name)
        {
            var response = new ApiResponse<TenantDto>();
            var result = _tenantRepository.GetTenantByName(name);
            response.Data = _mapper.Map<TenantDto>(result);
            return response;
        }

    }
}
