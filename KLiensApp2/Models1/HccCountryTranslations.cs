using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_CountryTranslations")]
[Index("CountryId", "Culture", Name = "IX_hcc_CountryTranslations", IsUnique = true)]
public partial class HccCountryTranslations
{
    [Key]
    public long CountryTranslationId { get; set; }

    public Guid CountryId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? DisplayName { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("HccCountryTranslations")]
    public virtual HccCountries Country { get; set; } = null!;
}
