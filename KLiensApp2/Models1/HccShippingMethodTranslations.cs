using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ShippingMethodTranslations")]
public partial class HccShippingMethodTranslations
{
    [Key]
    public long ShippingMethodTranslationId { get; set; }

    public Guid ShippingMethodId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? Name { get; set; }

    [ForeignKey("ShippingMethodId")]
    [InverseProperty("HccShippingMethodTranslations")]
    public virtual HccShippingMethod ShippingMethod { get; set; } = null!;
}
