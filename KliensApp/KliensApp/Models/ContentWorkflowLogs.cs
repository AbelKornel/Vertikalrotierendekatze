using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ContentItemId", Name = "IX_ContentWorkflowLogs_ContentItemId")]
public partial class ContentWorkflowLogs
{
    [Key]
    [Column("WorkflowLogID")]
    public int WorkflowLogId { get; set; }

    [StringLength(40)]
    public string Action { get; set; } = null!;

    public string Comment { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    public int User { get; set; }

    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [Column("ContentItemID")]
    public int ContentItemId { get; set; }

    public int Type { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("ContentWorkflowLogs")]
    public virtual ContentItems ContentItem { get; set; } = null!;

    [ForeignKey("WorkflowId")]
    [InverseProperty("ContentWorkflowLogs")]
    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
