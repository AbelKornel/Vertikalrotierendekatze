using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_StoreDomains")]
[Index("DomainName", Name = "IX_hcc_StoreDomains_DomainName")]
[Index("StoreId", Name = "IX_hcc_StoreDomains_StoreId")]
public partial class HccStoreDomains
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(255)]
    public string DomainName { get; set; } = null!;
}
