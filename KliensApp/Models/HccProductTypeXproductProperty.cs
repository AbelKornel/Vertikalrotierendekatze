using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductTypeXProductProperty")]
[Index("ProductTypeBvin", Name = "IX_hcc_ProductTypeXProductProperty_ProductTypeBvin")]
[Index("PropertyId", Name = "IX_hcc_ProductTypeXProductProperty_PropertyId")]
[Index("StoreId", Name = "IX_hcc_ProductTypeXProductProperty_StoreId")]
public partial class HccProductTypeXproductProperty
{
    public Guid ProductTypeBvin { get; set; }

    public long PropertyId { get; set; }

    public int SortOrder { get; set; }

    public long StoreId { get; set; }

    [Key]
    public long Id { get; set; }

    [ForeignKey("ProductTypeBvin")]
    [InverseProperty("HccProductTypeXproductProperty")]
    public virtual HccProductType ProductTypeBvinNavigation { get; set; } = null!;

    [ForeignKey("PropertyId")]
    [InverseProperty("HccProductTypeXproductProperty")]
    public virtual HccProductProperty Property { get; set; } = null!;
}
