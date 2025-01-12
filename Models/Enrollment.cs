﻿using System;
using System.Collections.Generic;

namespace BrainStormEra.Models;

public partial class Enrollment
{
    public string EnrollmentId { get; set; } = null!;

    public string? UserId { get; set; }

    public string? CourseId { get; set; }

    public int? EnrollmentStatus { get; set; }

    public bool? ApprovedByAdmin { get; set; }

    public DateOnly? CertificateIssuedDate { get; set; }

    public DateTime EnrollmentCreatedAt { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Status? EnrollmentStatusNavigation { get; set; }

    public virtual Account? User { get; set; }

    public virtual ICollection<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
}
