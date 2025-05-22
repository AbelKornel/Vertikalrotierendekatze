using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("TabId", "SettingName")]
public partial class TabSettings
{
    [Key]
    [Column("TabID")]
    public int TabId { get; set; }

    [Key]
    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("TabId")]
    [InverseProperty("TabSettings")]
    public virtual Tabs Tab { get; set; } = null!;
}
