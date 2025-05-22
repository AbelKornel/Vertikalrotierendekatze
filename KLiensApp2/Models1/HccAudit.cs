using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Audit")]
public partial class HccAudit
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStampUtc { get; set; }

    public int SourceModule { get; set; }

    [StringLength(255)]
    public string ShortName { get; set; } = null!;

    public string Description { get; set; } = null!;

    [StringLength(50)]
    public string UserId { get; set; } = null!;

    [StringLength(255)]
    public string UserIdText { get; set; } = null!;

    public int Severity { get; set; }

    public long StoreId { get; set; }
}
