using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("RelatedUserId", Name = "IX_UserRelationships_RelatedUserID")]
[Index("UserId", Name = "IX_UserRelationships_UserID")]
[Index("UserId", "RelatedUserId", "RelationshipId", Name = "IX_UserRelationships_UserID_RelatedUserID_RelationshipID", IsUnique = true)]
public partial class UserRelationships
{
    [Key]
    [Column("UserRelationshipID")]
    public int UserRelationshipId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("RelatedUserID")]
    public int RelatedUserId { get; set; }

    [Column("RelationshipID")]
    public int RelationshipId { get; set; }

    public int Status { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("RelatedUserId")]
    [InverseProperty("UserRelationshipsRelatedUser")]
    public virtual Users RelatedUser { get; set; } = null!;

    [ForeignKey("RelationshipId")]
    [InverseProperty("UserRelationships")]
    public virtual Relationships Relationship { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserRelationshipsUser")]
    public virtual Users User { get; set; } = null!;
}
