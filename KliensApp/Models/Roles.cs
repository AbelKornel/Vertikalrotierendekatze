using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "RoleName", Name = "IX_RoleName", IsUnique = true)]
[Index("BillingFrequency", Name = "IX_Roles")]
[Index("RoleGroupId", "RoleName", Name = "IX_Roles_RoleGroup")]
[Index("RoleId", "Status", Name = "IX_Roles_RoleID_Status", IsUnique = true)]
[Index("PortalId", "RoleName", Name = "IX_Roles_RoleName", IsUnique = true)]
public partial class Roles
{
    [Key]
    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string RoleName { get; set; } = null!;

    [StringLength(1000)]
    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? ServiceFee { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BillingFrequency { get; set; }

    public int? TrialPeriod { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TrialFrequency { get; set; }

    public int? BillingPeriod { get; set; }

    [Column(TypeName = "money")]
    public decimal? TrialFee { get; set; }

    public bool IsPublic { get; set; }

    public bool AutoAssignment { get; set; }

    [Column("RoleGroupID")]
    public int? RoleGroupId { get; set; }

    [Column("RSVPCode")]
    [StringLength(50)]
    public string? Rsvpcode { get; set; }

    [StringLength(100)]
    public string? IconFile { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public int Status { get; set; }

    public int SecurityMode { get; set; }

    public bool IsSystemRole { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; } = new List<DesktopModulePermission>();

    [InverseProperty("Role")]
    public virtual ICollection<FolderPermission> FolderPermission { get; set; } = new List<FolderPermission>();

    [InverseProperty("Role")]
    public virtual ICollection<ModulePermission> ModulePermission { get; set; } = new List<ModulePermission>();

    [InverseProperty("Role")]
    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; } = new List<PersonaBarMenuPermission>();

    [ForeignKey("PortalId")]
    [InverseProperty("Roles")]
    public virtual Portals? Portal { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<PortalPermission> PortalPermission { get; set; } = new List<PortalPermission>();

    [ForeignKey("RoleGroupId")]
    [InverseProperty("Roles")]
    public virtual RoleGroups? RoleGroup { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<TabPermission> TabPermission { get; set; } = new List<TabPermission>();

    [InverseProperty("Role")]
    public virtual ICollection<UserRoles> UserRoles { get; set; } = new List<UserRoles>();
}
