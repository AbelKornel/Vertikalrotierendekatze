using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class HtmlTextUsers
{
    [Key]
    [Column("HtmlTextUserID")]
    public int HtmlTextUserId { get; set; }

    [Column("ItemID")]
    public int ItemId { get; set; }

    [Column("StateID")]
    public int StateId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Column("TabID")]
    public int TabId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("HtmlTextUsers")]
    public virtual HtmlText Item { get; set; } = null!;
}
