using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TenantsController : GenericController<TenantDto>
    {
        private readonly ITenantService _tenantService;
        public TenantsController(ITenantService service) : base(service)
        {
            _tenantService = service;
        }

        [HttpGet("GetTenantByName")]
        public ApiResponse<TenantDto> GetTenantByNames(string name)
        {
            return _tenantService.GetTenantByName(name);
        }

    }
}
