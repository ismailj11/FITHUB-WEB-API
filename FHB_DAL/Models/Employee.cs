using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? FkUserId { get; set; }

    public decimal? Salary { get; set; }

    public string? EmployeeName { get; set; }

    public DateOnly? DateOfHire { get; set; }

    public virtual ICollection<Coach> Coaches { get; set; } = new List<Coach>();

    public virtual User? FkUser { get; set; }
}
