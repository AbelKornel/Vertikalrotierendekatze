using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductTypeTranslations")]
[Index("ProductTypeId", "Culture", Name = "UK_hcc_ProductTypeTranslations", IsUnique = true)]
public partial class HccProductTypeTranslations
{
    [Key]
    public long ProductTypeTranslationId { get; set; }

    public Guid ProductTypeId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(512)]
    public string? ProductTypeName { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("HccProductTypeTranslations")]
    public virtual HccProductType ProductType { get; set; } = null!;
}
