using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.DTO.Tenants
{
    public class TenantDto
    {
        public int TenantID { get; set; }

        public string? TenantName { get; set; }

        public bool? Status { get; set; }


        public DateOnly?  StartDate { get; set; }

        public DateOnly? EndDate { get; set; }
    }
}
