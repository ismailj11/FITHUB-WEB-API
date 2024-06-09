using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public int? FkUserId { get; set; }

    public string? MemberName { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public virtual User? FkUser { get; set; }

    public virtual ICollection<GymSub> GymSubs { get; set; } = new List<GymSub>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<PersonalTrainerSub> PersonalTrainerSubs { get; set; } = new List<PersonalTrainerSub>();
}
