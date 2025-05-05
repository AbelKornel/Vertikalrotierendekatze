using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductPropertyChoice")]
[Index("PropertyId", Name = "IX_hcc_ProductPropertyChoice")]
public partial class HccProductPropertyChoice
{
    [Key]
    public long Id { get; set; }

    public long PropertyId { get; set; }

    [StringLength(512)]
    public string ChoiceName { get; set; } = null!;

    public int SortOrder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [InverseProperty("ProductPropertyChoice")]
    public virtual ICollection<HccProductPropertyChoiceTranslations> HccProductPropertyChoiceTranslations { get; set; } = new List<HccProductPropertyChoiceTranslations>();

    [ForeignKey("PropertyId")]
    [InverseProperty("HccProductPropertyChoice")]
    public virtual HccProductProperty Property { get; set; } = null!;
}
