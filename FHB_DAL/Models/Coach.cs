using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class Coach
{
    public string? CoachName { get; set; }

    public int CoachId { get; set; }

    public int FkEmployeeId { get; set; }

    public string? Specialization { get; set; }

    public virtual Employee FkEmployee { get; set; } = null!;

    public virtual ICollection<TrainingRecord> TrainingRecords { get; set; } = new List<TrainingRecord>();
}
