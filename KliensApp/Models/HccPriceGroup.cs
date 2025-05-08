using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_PriceGroup")]
public partial class HccPriceGroup
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    [StringLength(255)]
    public string Name { get; set; } = null!;

    public int PricingType { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal AdjustmentAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
