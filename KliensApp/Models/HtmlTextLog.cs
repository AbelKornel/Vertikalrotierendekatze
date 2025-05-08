using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ItemId", Name = "IX_HtmlTextLog_ItemID")]
public partial class HtmlTextLog
{
    [Key]
    [Column("HtmlTextLogID")]
    public int HtmlTextLogId { get; set; }

    [Column("ItemID")]
    public int ItemId { get; set; }

    [Column("StateID")]
    public int StateId { get; set; }

    [StringLength(4000)]
    public string? Comment { get; set; }

    public bool Approved { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("HtmlTextLog")]
    public virtual HtmlText Item { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("HtmlTextLog")]
    public virtual WorkflowStates State { get; set; } = null!;
}
