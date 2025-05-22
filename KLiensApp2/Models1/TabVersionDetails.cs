using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("TabVersionId", Name = "IX_TabVersionDetails_TabVersionId")]
[Index("TabVersionId", "ModuleId", Name = "IX_TabVersionDetails_Unique(TabVersionId_ModuleId)", IsUnique = true)]
public partial class TabVersionDetails
{
    [Key]
    public int TabVersionDetailId { get; set; }

    public int TabVersionId { get; set; }

    public int ModuleId { get; set; }

    public int ModuleVersion { get; set; }

    [StringLength(50)]
    public string PaneName { get; set; } = null!;

    public int ModuleOrder { get; set; }

    public int Action { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("TabVersionId")]
    [InverseProperty("TabVersionDetails")]
    public virtual TabVersions TabVersion { get; set; } = null!;
}
