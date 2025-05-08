using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("MessageName", "PortalId", Name = "IX_SystemMessages", IsUnique = true)]
public partial class SystemMessages
{
    [Key]
    [Column("MessageID")]
    public int MessageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string MessageName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string MessageValue { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("SystemMessages")]
    public virtual Portals? Portal { get; set; }
}
