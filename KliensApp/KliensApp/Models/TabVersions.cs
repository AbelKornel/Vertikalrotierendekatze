using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("TabId", "Version", Name = "IX_TabVersions", IsUnique = true)]
[Index("TabId", Name = "IX_TabVersions_TabId")]
public partial class TabVersions
{
    [Key]
    public int TabVersionId { get; set; }

    public int TabId { get; set; }

    public int Version { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    public bool IsPublished { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("TabId")]
    [InverseProperty("TabVersions")]
    public virtual Tabs Tab { get; set; } = null!;

    [InverseProperty("TabVersion")]
    public virtual ICollection<TabVersionDetails> TabVersionDetails { get; set; } = new List<TabVersionDetails>();
}
