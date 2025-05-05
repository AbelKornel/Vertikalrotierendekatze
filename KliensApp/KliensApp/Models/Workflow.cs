using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "WorkflowName", Name = "IX_Workflow", IsUnique = true)]
public partial class Workflow
{
    [Key]
    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string WorkflowName { get; set; } = null!;

    [StringLength(2000)]
    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("Workflow")]
    public virtual ICollection<WorkflowStates> WorkflowStates { get; set; } = new List<WorkflowStates>();
}
