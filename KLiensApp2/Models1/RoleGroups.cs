using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "RoleGroupName", Name = "IX_RoleGroupName", IsUnique = true)]
public partial class RoleGroups
{
    [Key]
    [Column("RoleGroupID")]
    public int RoleGroupId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [StringLength(50)]
    public string RoleGroupName { get; set; } = null!;

    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("RoleGroups")]
    public virtual Portals Portal { get; set; } = null!;

    [InverseProperty("RoleGroup")]
    public virtual ICollection<Roles> Roles { get; set; } = new List<Roles>();
}
