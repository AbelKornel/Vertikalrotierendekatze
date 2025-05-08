using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("MetaDataName", Name = "IX_MetaData_MetaDataName", IsUnique = true)]
public partial class MetaData
{
    [Key]
    [Column("MetaDataID")]
    public int MetaDataId { get; set; }

    [StringLength(100)]
    public string MetaDataName { get; set; } = null!;

    [StringLength(2500)]
    public string? MetaDataDescription { get; set; }

    [InverseProperty("MetaData")]
    public virtual ICollection<ContentItemsMetaData> ContentItemsMetaData { get; set; } = new List<ContentItemsMetaData>();
}
