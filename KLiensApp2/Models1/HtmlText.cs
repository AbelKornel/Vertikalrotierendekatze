using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ModuleId", "Version", Name = "IX_HtmlText_ModuleID_Version")]
public partial class HtmlText
{
    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Key]
    [Column("ItemID")]
    public int ItemId { get; set; }

    [Column(TypeName = "ntext")]
    public string? Content { get; set; }

    public int? Version { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    public bool? IsPublished { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [Column(TypeName = "ntext")]
    public string? Summary { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<HtmlTextLog> HtmlTextLog { get; set; } = new List<HtmlTextLog>();

    [InverseProperty("Item")]
    public virtual ICollection<HtmlTextUsers> HtmlTextUsers { get; set; } = new List<HtmlTextUsers>();

    [ForeignKey("ModuleId")]
    [InverseProperty("HtmlText")]
    public virtual Modules Module { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("HtmlText")]
    public virtual WorkflowStates? State { get; set; }
}
