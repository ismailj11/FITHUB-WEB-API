using System;
using System.Collections.Generic;

namespace FHB_DAL.Models;

public partial class TrainingRecord
{
    public int RecordId { get; set; }

    public int? FkCoachId { get; set; }

    public string? TrainingType { get; set; }

    public DateOnly? Trainingdate { get; set; }

    public string? Trainer { get; set; }

    public string? Description { get; set; }

    public virtual Coach? FkCoach { get; set; }

    public virtual ICollection<PersonalTrainerSub> PersonalTrainerSubs { get; set; } = new List<PersonalTrainerSub>();
}
