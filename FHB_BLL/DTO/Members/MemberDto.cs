using FHB_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.DTO.Members
{
    public class MemberDto
    {
        public int MemberId { get; set; }

        public int? FkUserId { get; set; }

        public string? MemberName { get; set; }

        public DateOnly? RegistrationDate { get; set; }
    }
}
