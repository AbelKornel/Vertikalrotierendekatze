using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Fraud")]
public partial class HccFraud
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    public int RuleType { get; set; }

    [StringLength(255)]
    public string RuleValue { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
