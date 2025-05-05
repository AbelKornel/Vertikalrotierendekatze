using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwLists
{
    [Column("EntryID")]
    public int EntryId { get; set; }

    [StringLength(50)]
    public string ListName { get; set; } = null!;

    [StringLength(100)]
    public string Value { get; set; } = null!;

    [StringLength(150)]
    public string Text { get; set; } = null!;

    public int Level { get; set; }

    public int SortOrder { get; set; }

    [Column("DefinitionID")]
    public int DefinitionId { get; set; }

    [Column("ParentID")]
    public int ParentId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    public bool SystemList { get; set; }

    [StringLength(2000)]
    public string? ParentKey { get; set; }

    [StringLength(2000)]
    public string? Parent { get; set; }

    [StringLength(2000)]
    public string? ParentList { get; set; }

    public int? MaxSortOrder { get; set; }

    public int? EntryCount { get; set; }

    public int HasChildren { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
