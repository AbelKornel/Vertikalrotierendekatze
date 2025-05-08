using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_StoresXUsers")]
[Index("StoreId", Name = "IX_hcc_StoresXUsers_StoreId")]
[Index("UserId", Name = "IX_hcc_StoresXUsers_UserId")]
public partial class HccStoresXusers
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    public long UserId { get; set; }

    public int AccessMode { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("HccStoresXusers")]
    public virtual HccStores Store { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("HccStoresXusers")]
    public virtual HccUserAccounts User { get; set; } = null!;
}
