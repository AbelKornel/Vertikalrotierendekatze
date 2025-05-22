using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ContentColumn")]
public partial class HccContentColumn
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [StringLength(512)]
    public string DisplayName { get; set; } = null!;

    public int SystemColumn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [InverseProperty("Column")]
    public virtual ICollection<HccContentBlock> HccContentBlock { get; set; } = new List<HccContentBlock>();
}
