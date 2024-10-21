using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrainStormEra.Models;

public partial class Chapter
{
    [Required(ErrorMessage = "Chapter ID is required.")]
    public string ChapterId { get; set; } = null!;

    public string? CourseId { get; set; }

    [Required(ErrorMessage = "Chapter title is required.")]
    public string ChapterName { get; set; } = null!;

    [Required(ErrorMessage = "Chapter description is required.")]
    public string? ChapterDescription { get; set; }

    public int? ChapterOrder { get; set; }

    public int? ChapterStatus { get; set; }

    public DateTime ChapterCreatedAt { get; set; }

    public virtual Status? ChapterStatusNavigation { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
