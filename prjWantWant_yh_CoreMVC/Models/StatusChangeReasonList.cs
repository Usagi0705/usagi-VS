﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class StatusChangeReasonList
{
    public int StatusChangeReasonId { get; set; }

    public string? StatusChangeReason { get; set; }

    public virtual ICollection<MemberStatusList> MemberStatusLists { get; set; } = new List<MemberStatusList>();
}
