using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductProperty")]
public partial class HccProductProperty
{
    [Key]
    public long Id { get; set; }

    [StringLength(512)]
    public string PropertyName { get; set; } = null!;

    public int DisplayOnSite { get; set; }

    public int DisplayToDropShipper { get; set; }

    public int TypeCode { get; set; }

    [Column(TypeName = "ntext")]
    public string DefaultValue { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CultureCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public bool DisplayOnSearch { get; set; }

    public bool IsLocalizable { get; set; }

    [InverseProperty("Property")]
    public virtual ICollection<HccProductPropertyChoice> HccProductPropertyChoice { get; set; } = new List<HccProductPropertyChoice>();

    [InverseProperty("ProductProperty")]
    public virtual ICollection<HccProductPropertyTranslations> HccProductPropertyTranslations { get; set; } = new List<HccProductPropertyTranslations>();

    [InverseProperty("Property")]
    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValue { get; set; } = new List<HccProductPropertyValue>();

    [InverseProperty("Property")]
    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperty { get; set; } = new List<HccProductTypeXproductProperty>();
}
