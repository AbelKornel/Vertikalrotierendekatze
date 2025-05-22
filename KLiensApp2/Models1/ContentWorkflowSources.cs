using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("WorkflowId", "SourceName", Name = "IX_ContentWorkflowSources", IsUnique = true)]
public partial class ContentWorkflowSources
{
    [Key]
    [Column("SourceID")]
    public int SourceId { get; set; }

    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [StringLength(20)]
    public string SourceName { get; set; } = null!;

    [StringLength(250)]
    public string SourceType { get; set; } = null!;

    [ForeignKey("WorkflowId")]
    [InverseProperty("ContentWorkflowSources")]
    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
