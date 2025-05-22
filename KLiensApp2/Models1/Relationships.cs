using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("UserId", Name = "IX_Relationships_UserID")]
public partial class Relationships
{
    [Key]
    [Column("RelationshipID")]
    public int RelationshipId { get; set; }

    [Column("RelationshipTypeID")]
    public int RelationshipTypeId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    public int DefaultResponse { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("Relationships")]
    public virtual Portals? Portal { get; set; }

    [ForeignKey("RelationshipTypeId")]
    [InverseProperty("Relationships")]
    public virtual RelationshipTypes RelationshipType { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Relationships")]
    public virtual Users? User { get; set; }

    [InverseProperty("Relationship")]
    public virtual ICollection<UserRelationshipPreferences> UserRelationshipPreferences { get; set; } = new List<UserRelationshipPreferences>();

    [InverseProperty("Relationship")]
    public virtual ICollection<UserRelationships> UserRelationships { get; set; } = new List<UserRelationships>();
}
