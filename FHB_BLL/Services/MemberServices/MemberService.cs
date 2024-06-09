using AutoMapper;
using FHB_BLL.DTO.Employees;
using FHB_BLL.DTO.Members;
using FHB_BLL.Services.EmployeeServices;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Employees;
using FHB_DAL.Repositories.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.MemberServices
{
    public class MemberService : GenericService<Member, MemberDto>, IMemberService
    {
        public readonly IMemberRepository _memberRepository;
        public readonly IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IMapper mapper) : base(memberRepository, mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public ApiResponse<MemberDto> GetMemberByName(string name)
        {
            var response = new ApiResponse<MemberDto>();
            var result = _memberRepository.GetMemberByName(name);
            response.Data = _mapper.Map<MemberDto>(result);
            return response;
        }

    }
}
