using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("PreferenceId", "RelationshipId")]
public partial class UserRelationshipPreferences
{
    [Key]
    [Column("PreferenceID")]
    public int PreferenceId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Key]
    [Column("RelationshipID")]
    public int RelationshipId { get; set; }

    public int DefaultResponse { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("RelationshipId")]
    [InverseProperty("UserRelationshipPreferences")]
    public virtual Relationships Relationship { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserRelationshipPreferences")]
    public virtual Users User { get; set; } = null!;
}
