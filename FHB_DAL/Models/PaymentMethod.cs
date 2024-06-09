using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class PaymentMethod
{
    public int MethodId { get; set; }

    public string? Method { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
