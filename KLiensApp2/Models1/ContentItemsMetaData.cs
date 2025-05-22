using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("ContentItems_MetaData")]
[Index("ContentItemId", Name = "IX_ContentItems_MetaData_ContentItemId")]
[Index("ContentItemId", "MetaDataId", Name = "IX_ContentItems_MetaData_MetaDataID")]
public partial class ContentItemsMetaData
{
    [Key]
    [Column("ContentItemMetaDataID")]
    public int ContentItemMetaDataId { get; set; }

    [Column("ContentItemID")]
    public int ContentItemId { get; set; }

    [Column("MetaDataID")]
    public int MetaDataId { get; set; }

    public string? MetaDataValue { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("ContentItemsMetaData")]
    public virtual ContentItems ContentItem { get; set; } = null!;

    [ForeignKey("MetaDataId")]
    [InverseProperty("ContentItemsMetaData")]
    public virtual MetaData MetaData { get; set; } = null!;
}
