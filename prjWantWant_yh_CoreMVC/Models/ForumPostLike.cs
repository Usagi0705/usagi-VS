﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class ForumPostLike
{
    public int PostLikeId { get; set; }

    public int PostId { get; set; }

    public int AccountId { get; set; }

    public DateTime Created { get; set; }

    public virtual ForumPost Post { get; set; } = null!;
}
