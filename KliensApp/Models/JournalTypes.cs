using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_Types")]
public partial class JournalTypes
{
    [Key]
    public int JournalTypeId { get; set; }

    [StringLength(25)]
    public string? JournalType { get; set; }

    [Column("icon")]
    [StringLength(25)]
    public string? Icon { get; set; }

    public int PortalId { get; set; }

    public bool IsEnabled { get; set; }

    public bool AppliesToProfile { get; set; }

    public bool AppliesToGroup { get; set; }

    public bool AppliesToStream { get; set; }

    public string? Options { get; set; }

    public bool SupportsNotify { get; set; }

    public bool EnableComments { get; set; }

    [InverseProperty("JournalType")]
    public virtual ICollection<Journal> Journal { get; set; } = new List<Journal>();
}
