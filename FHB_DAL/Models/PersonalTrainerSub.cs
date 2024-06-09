using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class PersonalTrainerSub
{
    public int SubId { get; set; }

    public int? FkRecordId { get; set; }

    public int? FkMemberId { get; set; }

    public virtual Member? FkMember { get; set; }

    public virtual TrainingRecord? FkRecord { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
