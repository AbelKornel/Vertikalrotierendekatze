using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ListName", "ParentId", Name = "IX_Lists_ListName_ParentID")]
[Index("ListName", "Value", "Text", "ParentId", Name = "IX_Lists_ListName_Value_Text_ParentID", IsUnique = true)]
[Index("ParentId", "ListName", "Value", Name = "IX_Lists_ParentID", IsUnique = true)]
[Index("PortalId", "ParentId", "ListName", "SortOrder", Name = "IX_Lists_SortOrder")]
public partial class Lists
{
    [Key]
    [Column("EntryID")]
    public int EntryId { get; set; }

    [StringLength(50)]
    public string ListName { get; set; } = null!;

    [StringLength(100)]
    public string Value { get; set; } = null!;

    [StringLength(150)]
    public string Text { get; set; } = null!;

    [Column("ParentID")]
    public int ParentId { get; set; }

    public int Level { get; set; }

    public int SortOrder { get; set; }

    [Column("DefinitionID")]
    public int DefinitionId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    public bool SystemList { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
