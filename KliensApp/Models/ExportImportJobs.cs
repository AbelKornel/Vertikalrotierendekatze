using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("CreatedOnDate", Name = "IX_ExportImportJobs_CreatedOn")]
[Index("JobStatus", Name = "IX_ExportImportJobs_JobStatus")]
[Index("JobType", Name = "IX_ExportImportJobs_JobType")]
public partial class ExportImportJobs
{
    [Key]
    public int JobId { get; set; }

    public int PortalId { get; set; }

    public int JobType { get; set; }

    public int JobStatus { get; set; }

    public bool IsCancelled { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedOnDate { get; set; }

    [StringLength(100)]
    public string? Directory { get; set; }

    public string? JobObject { get; set; }

    [InverseProperty("Job")]
    public virtual ICollection<ExportImportCheckpoints> ExportImportCheckpoints { get; set; } = new List<ExportImportCheckpoints>();

    [InverseProperty("Job")]
    public virtual ICollection<ExportImportJobLogs> ExportImportJobLogs { get; set; } = new List<ExportImportJobLogs>();
}
