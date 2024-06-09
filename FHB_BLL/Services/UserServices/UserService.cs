using AutoMapper;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.DTO.UserDto;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Tenants;
using FHB_DAL.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.UserServices
{
    public class UserService : GenericService<User, UserDto>, IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public ApiResponse<UserDto> GetUserByUsername(string username)
        {
            var response = new ApiResponse<UserDto>();
            var result = _userRepository.GetUserByUsername(username);
            response.Data = _mapper.Map<UserDto>(result);
            return response;
        }

    }
}
