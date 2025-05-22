using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwContentWorkflowUsage
{
    public string? ContentName { get; set; }

    [StringLength(100)]
    public string ContentType { get; set; } = null!;

    [Column("WorkflowID")]
    public int? WorkflowId { get; set; }
}
