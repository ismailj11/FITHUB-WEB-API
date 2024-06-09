using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Tenant
{
    public int TenantId { get; set; }

    public string? TenantName { get; set; }

    public bool? Status { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual ICollection<GymSub> GymSubs { get; set; } = new List<GymSub>();
}
