using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwUserRoles
{
    [Column("UserRoleID")]
    public int UserRoleId { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string RoleName { get; set; } = null!;

    [StringLength(100)]
    public string Username { get; set; } = null!;

    [StringLength(1000)]
    public string? Description { get; set; }

    [StringLength(128)]
    public string DisplayName { get; set; } = null!;

    [StringLength(256)]
    public string? Email { get; set; }

    public int Status { get; set; }

    public bool IsOwner { get; set; }

    public int SecurityMode { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public bool? IsTrialUsed { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystemRole { get; set; }
}
