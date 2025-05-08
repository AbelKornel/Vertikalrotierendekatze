using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductOptionsItems")]
[Index("OptionBvin", Name = "IX_hcc_ProductOptionsItems")]
[Index("StoreId", Name = "IX_hcc_ProductOptionsItems_1")]
public partial class HccProductOptionsItems
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public Guid OptionBvin { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal PriceAdjustment { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal WeightAdjustment { get; set; }

    public bool IsLabel { get; set; }

    public int SortOrder { get; set; }

    public bool IsDefault { get; set; }

    [InverseProperty("ProductOptionItem")]
    public virtual ICollection<HccProductOptionItemTranslations> HccProductOptionItemTranslations { get; set; } = new List<HccProductOptionItemTranslations>();

    [ForeignKey("OptionBvin")]
    [InverseProperty("HccProductOptionsItems")]
    public virtual HccProductOptions OptionBvinNavigation { get; set; } = null!;
}
