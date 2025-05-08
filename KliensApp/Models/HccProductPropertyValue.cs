using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductPropertyValue")]
[Index("ProductBvin", Name = "IX_hcc_ProductPropertyValue_1")]
[Index("PropertyId", Name = "IX_hcc_ProductPropertyValue_2")]
public partial class HccProductPropertyValue
{
    public Guid ProductBvin { get; set; }

    public long PropertyId { get; set; }

    public string PropertyValue { get; set; } = null!;

    public long StoreId { get; set; }

    [Key]
    public long Id { get; set; }

    [InverseProperty("ProductPropertyValue")]
    public virtual ICollection<HccProductPropertyValueTranslations> HccProductPropertyValueTranslations { get; set; } = new List<HccProductPropertyValueTranslations>();

    [ForeignKey("ProductBvin")]
    [InverseProperty("HccProductPropertyValue")]
    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;

    [ForeignKey("PropertyId")]
    [InverseProperty("HccProductPropertyValue")]
    public virtual HccProductProperty Property { get; set; } = null!;
}
