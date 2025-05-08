using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("JobId", Name = "IX_ExportImportJobLogs_JobId")]
public partial class ExportImportJobLogs
{
    [Key]
    public int JobLogId { get; set; }

    public int JobId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? Value { get; set; }

    public int Level { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("ExportImportJobLogs")]
    public virtual ExportImportJobs Job { get; set; } = null!;
}
