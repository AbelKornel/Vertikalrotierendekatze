using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductOptions")]
[Index("StoreId", Name = "IX_hcc_ProductOptions_StoreID")]
public partial class HccProductOptions
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public int OptionType { get; set; }

    public bool NameIsHidden { get; set; }

    public bool IsVariant { get; set; }

    public bool IsShared { get; set; }

    public string Settings { get; set; } = null!;

    public bool IsColorSwatch { get; set; }

    [InverseProperty("ProductOption")]
    public virtual ICollection<HccProductOptionTranslations> HccProductOptionTranslations { get; set; } = new List<HccProductOptionTranslations>();

    [InverseProperty("OptionBvinNavigation")]
    public virtual ICollection<HccProductOptionsItems> HccProductOptionsItems { get; set; } = new List<HccProductOptionsItems>();

    [InverseProperty("OptionBvinNavigation")]
    public virtual ICollection<HccProductXoption> HccProductXoption { get; set; } = new List<HccProductXoption>();
}
