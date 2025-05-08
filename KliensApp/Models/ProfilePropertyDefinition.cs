using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "ModuleDefId", "PropertyName", Name = "IX_ProfilePropertyDefinition", IsUnique = true)]
[Index("PropertyName", Name = "IX_ProfilePropertyDefinition_PropertyName")]
public partial class ProfilePropertyDefinition
{
    [Key]
    [Column("PropertyDefinitionID")]
    public int PropertyDefinitionId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [Column("ModuleDefID")]
    public int? ModuleDefId { get; set; }

    public bool Deleted { get; set; }

    public int DataType { get; set; }

    [Column(TypeName = "ntext")]
    public string? DefaultValue { get; set; }

    [StringLength(50)]
    public string PropertyCategory { get; set; } = null!;

    [StringLength(50)]
    public string PropertyName { get; set; } = null!;

    public int Length { get; set; }

    public bool Required { get; set; }

    [StringLength(2000)]
    public string? ValidationExpression { get; set; }

    public int ViewOrder { get; set; }

    public bool Visible { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public int? DefaultVisibility { get; set; }

    public bool ReadOnly { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("ProfilePropertyDefinition")]
    public virtual Portals? Portal { get; set; }

    [InverseProperty("PropertyDefinition")]
    public virtual ICollection<UserProfile> UserProfile { get; set; } = new List<UserProfile>();
}
