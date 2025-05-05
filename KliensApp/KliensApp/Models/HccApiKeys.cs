using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ApiKeys")]
[Index("StoreId", Name = "IX_hcc_ApiKeys_StoreId")]
public partial class HccApiKeys
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(100)]
    public string ApiKey { get; set; } = null!;
}
