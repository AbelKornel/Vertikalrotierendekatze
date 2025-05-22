using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Countries")]
public partial class HccCountries
{
    [Key]
    public Guid CountryId { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    [StringLength(255)]
    public string? SystemName { get; set; }

    [StringLength(10)]
    public string? IsoCode { get; set; }

    [StringLength(10)]
    public string? IsoAlpha3 { get; set; }

    [StringLength(10)]
    public string? IsoNumeric { get; set; }

    [StringLength(10)]
    public string? PostalCodeValidationRegex { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<HccCountryTranslations> HccCountryTranslations { get; set; } = new List<HccCountryTranslations>();

    [InverseProperty("Country")]
    public virtual ICollection<HccRegions> HccRegions { get; set; } = new List<HccRegions>();
}
