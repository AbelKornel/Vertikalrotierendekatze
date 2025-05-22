using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_CustomUrl")]
[Index("SystemData", Name = "IX_hcc_CustomUrl")]
public partial class HccCustomUrl
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    public string RequestedUrl { get; set; } = null!;

    public string RedirectToUrl { get; set; } = null!;

    public bool IsPermanentRedirect { get; set; }

    public int SystemDataType { get; set; }

    [StringLength(50)]
    public string SystemData { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
