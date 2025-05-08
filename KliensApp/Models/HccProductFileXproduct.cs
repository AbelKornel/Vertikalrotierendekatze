using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductFileXProduct")]
[Index("ProductFileId", Name = "IX_hcc_ProductFileXProduct")]
[Index("ProductFileId", "ProductId", Name = "IX_hcc_ProductFileXProduct_1", IsUnique = true)]
[Index("ProductId", Name = "IX_hcc_ProductFileXProduct_2")]
public partial class HccProductFileXproduct
{
    public Guid ProductFileId { get; set; }

    public Guid ProductId { get; set; }

    public int AvailableMinutes { get; set; }

    public int MaxDownloads { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [Key]
    public long Id { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductFileXproduct")]
    public virtual HccProduct Product { get; set; } = null!;

    [ForeignKey("ProductFileId")]
    [InverseProperty("HccProductFileXproduct")]
    public virtual HccProductFile ProductFile { get; set; } = null!;
}
