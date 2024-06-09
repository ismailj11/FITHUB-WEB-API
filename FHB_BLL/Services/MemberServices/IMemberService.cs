using FHB_BLL.DTO.Employees;
using FHB_BLL.DTO.Members;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.MemberServices
{
    public interface IMemberService : IGenericService<MemberDto>
    {
        ApiResponse<MemberDto> GetMemberByName(string name);
    }
}
