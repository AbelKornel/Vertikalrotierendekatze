using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("UserId", "PortalId")]
public partial class UsersOnline
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

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
    [InverseProperty("UsersOnline")]
    public virtual Portals Portal { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UsersOnline")]
    public virtual Users User { get; set; } = null!;
}
