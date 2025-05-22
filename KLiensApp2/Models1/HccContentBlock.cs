using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ContentBlock")]
public partial class HccContentBlock
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column("ColumnID")]
    public Guid ColumnId { get; set; }

    public int SortOrder { get; set; }

    [StringLength(512)]
    public string ControlName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [Column(TypeName = "ntext")]
    public string SerializedSettings { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string SerializedLists { get; set; } = null!;

    [ForeignKey("ColumnId")]
    [InverseProperty("HccContentBlock")]
    public virtual HccContentColumn Column { get; set; } = null!;

    [InverseProperty("ContentBlock")]
    public virtual ICollection<HccContentBlockTranslations> HccContentBlockTranslations { get; set; } = new List<HccContentBlockTranslations>();
}
