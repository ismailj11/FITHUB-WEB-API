using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public int? FkMemberId { get; set; }

    public decimal? Amount { get; set; }

    public int? FkMethodId { get; set; }

    public string? TransactionId { get; set; }

    public bool? PaymentStatus { get; set; }

    public string? Notes { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public int? FkProductId { get; set; }

    public int? FkSubscriberId { get; set; }

    public int? FkPersonalTrainerSubId { get; set; }

    public virtual Member? FkMember { get; set; }

    public virtual PaymentMethod? FkMethod { get; set; }

    public virtual PersonalTrainerSub? FkPersonalTrainerSub { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual GymSub? FkSubscriber { get; set; }
}
