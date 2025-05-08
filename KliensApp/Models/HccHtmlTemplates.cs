using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_HtmlTemplates")]
[Index("StoreId", Name = "IX_hcc_HtmlTemplates_StoreId")]
public partial class HccHtmlTemplates
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [StringLength(255)]
    public string DisplayName { get; set; } = null!;

    [StringLength(255)]
    public string FromEmail { get; set; } = null!;

    public int TemplateType { get; set; }

    [InverseProperty("HtmlTemplate")]
    public virtual ICollection<HccHtmlTemplateTranslations> HccHtmlTemplateTranslations { get; set; } = new List<HccHtmlTemplateTranslations>();
}
