using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_RegionTranslations")]
[Index("RegionId", "Culture", Name = "IX_hcc_RegionTranslations", IsUnique = true)]
public partial class HccRegionTranslations
{
    [Key]
    public long RegionTranslationId { get; set; }

    public Guid RegionId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? DisplayName { get; set; }

    [ForeignKey("RegionId")]
    [InverseProperty("HccRegionTranslations")]
    public virtual HccRegions Region { get; set; } = null!;
}
