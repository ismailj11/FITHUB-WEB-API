using FHB_BLL.DTO.Tenants;
using FHB_BLL.DTO.UserDto;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Services.UserServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : GenericController<UserDto>
    {
        private readonly IUserService _userService;
        public UsersController(IUserService service) : base(service)
        {
            _userService = service;
        }

        [HttpGet("GetUserByUsername")]
        public ApiResponse<UserDto> GetUserByUsernames(string username)
        {
            return _userService.GetUserByUsername(username);
        }

    }
}
