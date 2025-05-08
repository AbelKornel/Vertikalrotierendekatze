using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("RoleId", "UserId", Name = "IX_UserRoles_RoleID_UserID", IsUnique = true)]
[Index("RoleId", "UserId", Name = "IX_UserRoles_RoleUser", IsUnique = true)]
[Index("Status", "EffectiveDate", Name = "IX_UserRoles_Status_EffectiveDate")]
[Index("UserId", "RoleId", Name = "IX_UserRoles_UserRole", IsUnique = true)]
public partial class UserRoles
{
    [Key]
    [Column("UserRoleID")]
    public int UserRoleId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public bool? IsTrialUsed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public int Status { get; set; }

    public bool IsOwner { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("UserRoles")]
    public virtual Roles Role { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserRoles")]
    public virtual Users User { get; set; } = null!;
}
