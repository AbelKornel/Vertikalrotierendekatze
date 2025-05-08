using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "WorkflowName", Name = "IX_ContentWorkflows", IsUnique = true)]
public partial class ContentWorkflows
{
    [Key]
    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(40)]
    public string WorkflowName { get; set; } = null!;

    [StringLength(256)]
    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool StartAfterCreating { get; set; }

    public bool StartAfterEditing { get; set; }

    public bool DispositionEnabled { get; set; }

    public bool IsSystem { get; set; }

    [StringLength(40)]
    public string WorkflowKey { get; set; } = null!;

    [InverseProperty("Workflow")]
    public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; } = new List<ContentWorkflowLogs>();

    [InverseProperty("Workflow")]
    public virtual ICollection<ContentWorkflowSources> ContentWorkflowSources { get; set; } = new List<ContentWorkflowSources>();

    [InverseProperty("Workflow")]
    public virtual ICollection<ContentWorkflowStates> ContentWorkflowStates { get; set; } = new List<ContentWorkflowStates>();

    [InverseProperty("Workflow")]
    public virtual ICollection<Folders> Folders { get; set; } = new List<Folders>();
}
