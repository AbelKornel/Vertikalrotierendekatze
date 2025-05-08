using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("UserId", "PortalId")]
public partial class AnonymousUsers
{
    [Key]
    [Column("UserID")]
    [StringLength(36)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("TabID")]
    public int TabId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastActiveDate { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("AnonymousUsers")]
    public virtual Portals Portal { get; set; } = null!;
}
