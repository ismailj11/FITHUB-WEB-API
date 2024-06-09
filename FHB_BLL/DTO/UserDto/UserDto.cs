using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.DTO.UserDto
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public DateOnly? Dob { get; set; }

        public string? Gender { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public bool? Status { get; set; }

        
    }
}
