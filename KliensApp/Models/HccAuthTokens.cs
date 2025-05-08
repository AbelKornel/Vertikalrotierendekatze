using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_AuthTokens")]
public partial class HccAuthTokens
{
    [Key]
    public long Id { get; set; }

    public Guid TokenId { get; set; }

    public long UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Expires { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("HccAuthTokens")]
    public virtual HccUserAccounts User { get; set; } = null!;
}
