using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_QueuedTasks")]
[Index("Status", Name = "IX_hcc_QueuedTasks_Status")]
[Index("StoreId", Name = "IX_hcc_QueuedTasks_StoreId")]
public partial class HccQueuedTasks
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(255)]
    public string FriendlyName { get; set; } = null!;

    [StringLength(255)]
    public string TaskProcessorName { get; set; } = null!;

    public Guid TaskProcessorId { get; set; }

    public string Payload { get; set; } = null!;

    public int Status { get; set; }

    public string StatusNotes { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartAtUtc { get; set; }
}
