using FHB_BLL.DTO.Employees;
using FHB_BLL.DTO.Members;
using FHB_BLL.Services;
using FHB_BLL.Services.EmployeeServices;
using FHB_BLL.Services.MemberServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MembersController : GenericController<MemberDto>
    {
        private readonly  IMemberService _memberService ;
        public MembersController(IMemberService service) : base(service)
        {
            _memberService = service;
        }

        [HttpGet("GetMemberByName")]
        public ApiResponse<MemberDto> GetMemberByNames(string name)
        {
            return _memberService.GetMemberByName(name);
        }

    }
}
