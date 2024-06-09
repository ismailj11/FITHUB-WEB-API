using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
