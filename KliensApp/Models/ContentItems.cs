using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("TabId", Name = "IX_ContentItems_TabID")]
public partial class ContentItems
{
    [Key]
    [Column("ContentItemID")]
    public int ContentItemId { get; set; }

    public string? Content { get; set; }

    [Column("ContentTypeID")]
    public int ContentTypeId { get; set; }

    [Column("TabID")]
    public int TabId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [StringLength(250)]
    public string? ContentKey { get; set; }

    public bool Indexed { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    [InverseProperty("ContentItem")]
    public virtual ICollection<ContentItemsMetaData> ContentItemsMetaData { get; set; } = new List<ContentItemsMetaData>();

    [InverseProperty("ContentItem")]
    public virtual ICollection<ContentItemsTags> ContentItemsTags { get; set; } = new List<ContentItemsTags>();

    [ForeignKey("ContentTypeId")]
    [InverseProperty("ContentItems")]
    public virtual ContentTypes ContentType { get; set; } = null!;

    [InverseProperty("ContentItem")]
    public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; } = new List<ContentWorkflowLogs>();

    [InverseProperty("ContentItem")]
    public virtual ICollection<Files> Files { get; set; } = new List<Files>();

    [InverseProperty("ContentItem")]
    public virtual ICollection<Modules> Modules { get; set; } = new List<Modules>();

    [ForeignKey("StateId")]
    [InverseProperty("ContentItems")]
    public virtual ContentWorkflowStates? State { get; set; }

    [InverseProperty("ContentItem")]
    public virtual ICollection<Tabs> Tabs { get; set; } = new List<Tabs>();
}
