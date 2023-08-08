﻿using System;
using System.Collections.Generic;

namespace prjWantWant_yh_CoreMVC.Models;

public partial class ResumeCertificate
{
    public int ResumeCertificateId { get; set; }

    public int CertificateId { get; set; }

    public int ResumeId { get; set; }

    public virtual Certificate Certificate { get; set; } = null!;

    public virtual Resume Resume { get; set; } = null!;
}
