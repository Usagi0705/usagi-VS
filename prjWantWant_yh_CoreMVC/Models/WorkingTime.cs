﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class WorkingTime
{
    public int WorkingHoursId { get; set; }

    public string? WorkingDateFrom { get; set; }

    public string? WorkingDateTo { get; set; }

    public string? WorkingHoursFrom { get; set; }

    public string? WorkingHoursTo { get; set; }

    public virtual ICollection<Resume> Resumes { get; set; } = new List<Resume>();
}
