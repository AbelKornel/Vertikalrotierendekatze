using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_USGeoData")]
public partial class HccUsgeoData
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Zip { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Longitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string County { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ZipType { get; set; } = null!;
}
