using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Category", Name = "IX_ExportImportCheckpoints_Category")]
[Index("Category", "AssemblyName", "JobId", Name = "IX_ExportImportCheckpoints_Composite", IsUnique = true)]
[Index("JobId", Name = "IX_ExportImportCheckpoints_JobId")]
public partial class ExportImportCheckpoints
{
    [Key]
    public int CheckpointId { get; set; }

    public int JobId { get; set; }

    [StringLength(200)]
    public string AssemblyName { get; set; } = null!;

    [StringLength(50)]
    public string Category { get; set; } = null!;

    public int Stage { get; set; }

    public string? StageData { get; set; }

    public int Progress { get; set; }

    public int TotalItems { get; set; }

    public int ProcessedItems { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public bool? Completed { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("ExportImportCheckpoints")]
    public virtual ExportImportJobs Job { get; set; } = null!;
}
