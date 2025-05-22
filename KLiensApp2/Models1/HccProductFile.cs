using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductFile")]
[Index("FileName", "ShortDescription", Name = "IX_hcc_ProductFile", IsUnique = true)]
public partial class HccProductFile
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [StringLength(100)]
    public string FileName { get; set; } = null!;

    [StringLength(100)]
    public string ShortDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [InverseProperty("ProductFile")]
    public virtual ICollection<HccProductFileXproduct> HccProductFileXproduct { get; set; } = new List<HccProductFileXproduct>();
}
