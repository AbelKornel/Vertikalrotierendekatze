using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class RoleSettings
{
    [Key]
    [Column("RoleSettingID")]
    public int RoleSettingId { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }
}
