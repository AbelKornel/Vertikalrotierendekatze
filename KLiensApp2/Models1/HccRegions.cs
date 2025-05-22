using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Regions")]
public partial class HccRegions
{
    [Key]
    public Guid RegionId { get; set; }

    public Guid CountryId { get; set; }

    [StringLength(10)]
    public string? Abbreviation { get; set; }

    [StringLength(255)]
    public string? SystemName { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("HccRegions")]
    public virtual HccCountries Country { get; set; } = null!;

    [InverseProperty("Region")]
    public virtual ICollection<HccRegionTranslations> HccRegionTranslations { get; set; } = new List<HccRegionTranslations>();
}
