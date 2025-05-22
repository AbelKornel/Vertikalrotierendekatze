using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("MenuId", "PermissionKey", Name = "IX_PersonaBarPermissionScope", IsUnique = true)]
public partial class PersonaBarPermission
{
    [Key]
    public int PermissionId { get; set; }

    public int? MenuId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PermissionKey { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PermissionName { get; set; } = null!;

    public int ViewOrder { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("PersonaBarPermission")]
    public virtual PersonaBarMenu? Menu { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; } = new List<PersonaBarMenuPermission>();
}
