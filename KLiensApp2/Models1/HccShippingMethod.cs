using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ShippingMethod")]
public partial class HccShippingMethod
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Adjustment { get; set; }

    public int AdjustmentType { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ShippingProviderId { get; set; } = null!;

    public long StoreId { get; set; }

    public long ZoneId { get; set; }

    [Column(TypeName = "ntext")]
    public string Settings { get; set; } = null!;

    public int VisibilityMode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VisibilityAmount { get; set; }

    public int SortOrder { get; set; }

    [InverseProperty("ShippingMethod")]
    public virtual ICollection<HccShippingMethodTranslations> HccShippingMethodTranslations { get; set; } = new List<HccShippingMethodTranslations>();
}
