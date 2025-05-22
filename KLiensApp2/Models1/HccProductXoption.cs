using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductXOption")]
[Index("OptionBvin", Name = "IX_hcc_ProductXOption_OptionBvin")]
[Index("ProductBvin", Name = "IX_hcc_ProductXOption_ProductBvin")]
public partial class HccProductXoption
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    public Guid ProductBvin { get; set; }

    public Guid OptionBvin { get; set; }

    public int SortOrder { get; set; }

    [ForeignKey("OptionBvin")]
    [InverseProperty("HccProductXoption")]
    public virtual HccProductOptions OptionBvinNavigation { get; set; } = null!;

    [ForeignKey("ProductBvin")]
    [InverseProperty("HccProductXoption")]
    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;
}
