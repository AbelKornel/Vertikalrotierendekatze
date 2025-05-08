using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_BundledProducts")]
public partial class HccBundledProducts
{
    [Key]
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid BundledProductId { get; set; }

    public int Quantity { get; set; }

    public string? SelectionData { get; set; }

    public int SortOrder { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccBundledProducts")]
    public virtual HccProduct Product { get; set; } = null!;
}
