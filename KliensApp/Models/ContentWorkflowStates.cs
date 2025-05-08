using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("WorkflowId", "StateName", Name = "IX_ContentWorkflowStates", IsUnique = true)]
public partial class ContentWorkflowStates
{
    [Key]
    [Column("StateID")]
    public int StateId { get; set; }

    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [StringLength(40)]
    public string StateName { get; set; } = null!;

    public int Order { get; set; }

    public bool IsActive { get; set; }

    public bool SendEmail { get; set; }

    public bool SendMessage { get; set; }

    public bool IsDisposalState { get; set; }

    [StringLength(256)]
    public string OnCompleteMessageSubject { get; set; } = null!;

    [StringLength(1024)]
    public string OnCompleteMessageBody { get; set; } = null!;

    [StringLength(256)]
    public string OnDiscardMessageSubject { get; set; } = null!;

    [StringLength(1024)]
    public string OnDiscardMessageBody { get; set; } = null!;

    public bool IsSystem { get; set; }

    public bool SendNotification { get; set; }

    public bool SendNotificationToAdministrators { get; set; }

    [InverseProperty("State")]
    public virtual ICollection<ContentItems> ContentItems { get; set; } = new List<ContentItems>();

    [InverseProperty("State")]
    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; } = new List<ContentWorkflowStatePermission>();

    [ForeignKey("WorkflowId")]
    [InverseProperty("ContentWorkflowStates")]
    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
