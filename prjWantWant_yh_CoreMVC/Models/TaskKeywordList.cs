﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class TaskKeywordList
{
    public int TaskKeywordListId { get; set; }

    public int? CaseId { get; set; }

    public int? KeywordId { get; set; }

    public virtual TaskList? Case { get; set; }

    public virtual Keyword? Keyword { get; set; }
}
