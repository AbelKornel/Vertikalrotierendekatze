using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("StateId", "PermissionId", "RoleId", "UserId", Name = "IX_ContentWorkflowStatePermission", IsUnique = true)]
public partial class ContentWorkflowStatePermission
{
    [Key]
    [Column("WorkflowStatePermissionID")]
    public int WorkflowStatePermissionId { get; set; }

    [Column("StateID")]
    public int StateId { get; set; }

    [Column("PermissionID")]
    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    [Column("RoleID")]
    public int? RoleId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("ContentWorkflowStatePermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("ContentWorkflowStatePermission")]
    public virtual ContentWorkflowStates State { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("ContentWorkflowStatePermission")]
    public virtual Users? User { get; set; }
}
