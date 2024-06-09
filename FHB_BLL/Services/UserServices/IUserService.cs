using FHB_BLL.DTO.Tenants;
using FHB_BLL.DTO.UserDto;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.UserServices
{
    public interface IUserService : IGenericService<UserDto>
    {
        ApiResponse<UserDto> GetUserByUsername(string username);
    }
}
