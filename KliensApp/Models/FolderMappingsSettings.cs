using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("FolderMappingId", "SettingName")]
public partial class FolderMappingsSettings
{
    [Key]
    [Column("FolderMappingID")]
    public int FolderMappingId { get; set; }

    [Key]
    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    [StringLength(2000)]
    public string SettingValue { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("FolderMappingId")]
    [InverseProperty("FolderMappingsSettings")]
    public virtual FolderMappings FolderMapping { get; set; } = null!;
}
