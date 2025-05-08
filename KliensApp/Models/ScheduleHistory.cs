using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ScheduleId", "NextStart", Name = "IX_ScheduleHistory_NextStart", IsDescending = new[] { false, true })]
[Index("ScheduleId", "StartDate", Name = "IX_ScheduleHistory_StartDate", IsDescending = new[] { false, true })]
public partial class ScheduleHistory
{
    [Key]
    [Column("ScheduleHistoryID")]
    public int ScheduleHistoryId { get; set; }

    [Column("ScheduleID")]
    public int ScheduleId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public bool? Succeeded { get; set; }

    [Column(TypeName = "ntext")]
    public string? LogNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextStart { get; set; }

    [StringLength(150)]
    public string? Server { get; set; }

    [ForeignKey("ScheduleId")]
    [InverseProperty("ScheduleHistory")]
    public virtual Schedule Schedule { get; set; } = null!;
}
