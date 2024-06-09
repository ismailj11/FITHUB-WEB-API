using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.DTO.Employees
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public int? FkUserId { get; set; }

        public decimal? Salary { get; set; }

        public string? EmployeeName { get; set; }

        public DateOnly? DateOfHire { get; set; }
    }
}
