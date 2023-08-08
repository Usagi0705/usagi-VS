﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class MemberRoleConn
{
    public int MemberRoleId { get; set; }

    public int AccountId { get; set; }

    public int RoleId { get; set; }

    public virtual MemberAccount Account { get; set; } = null!;

    public virtual RoleInfo Role { get; set; } = null!;
}
