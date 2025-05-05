using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductType")]
public partial class HccProductType
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public bool IsPermanent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [StringLength(500)]
    public string TemplateName { get; set; } = null!;

    [InverseProperty("ProductType")]
    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; set; } = new List<HccCatalogRoles>();

    [InverseProperty("ProductTypeBvinNavigation")]
    public virtual HccMembershipProductType? HccMembershipProductType { get; set; }

    [InverseProperty("ProductType")]
    public virtual ICollection<HccProduct> HccProduct { get; set; } = new List<HccProduct>();

    [InverseProperty("ProductType")]
    public virtual ICollection<HccProductTypeTranslations> HccProductTypeTranslations { get; set; } = new List<HccProductTypeTranslations>();

    [InverseProperty("ProductTypeBvinNavigation")]
    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperty { get; set; } = new List<HccProductTypeXproductProperty>();
}
