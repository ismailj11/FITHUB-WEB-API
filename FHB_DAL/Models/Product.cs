using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public double? Price { get; set; }

    public string? ProductName { get; set; }

    public double? Weight { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    public string? Brand { get; set; }

    public int? FkCategoryId { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
