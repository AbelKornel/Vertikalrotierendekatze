using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_UserXContact")]
[Index("ContactId", Name = "IX_hcc_UserXContact_ContactId")]
[Index("StoreId", Name = "IX_hcc_UserXContact_StoreId")]
[Index("UserId", Name = "IX_hcc_UserXContact_UserId")]
public partial class HccUserXcontact
{
    [Key]
    public long Id { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ContactId { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    public long StoreId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("HccUserXcontact")]
    public virtual HccUser User { get; set; } = null!;
}
