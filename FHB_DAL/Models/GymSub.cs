using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class GymSub
{
    public int SubscriberId { get; set; }

    public int? FkMemberId { get; set; }

    public DateOnly? MembershipStartDate { get; set; }

    public DateOnly? MembershipEndDate { get; set; }

    public int? FkTenantId { get; set; }

    public virtual Member? FkMember { get; set; }

    public virtual Tenant? FkTenant { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
