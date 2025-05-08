using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("WorkflowId", "StateName", Name = "IX_WorkflowStates", IsUnique = true)]
public partial class WorkflowStates
{
    [Key]
    [Column("StateID")]
    public int StateId { get; set; }

    [Column("WorkflowID")]
    public int WorkflowId { get; set; }

    [StringLength(50)]
    public string StateName { get; set; } = null!;

    public int Order { get; set; }

    public bool IsActive { get; set; }

    public bool Notify { get; set; }

    [InverseProperty("State")]
    public virtual ICollection<HtmlText> HtmlText { get; set; } = new List<HtmlText>();

    [InverseProperty("State")]
    public virtual ICollection<HtmlTextLog> HtmlTextLog { get; set; } = new List<HtmlTextLog>();

    [ForeignKey("WorkflowId")]
    [InverseProperty("WorkflowStates")]
    public virtual Workflow Workflow { get; set; } = null!;
}
