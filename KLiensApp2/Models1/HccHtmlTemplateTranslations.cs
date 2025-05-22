using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_HtmlTemplateTranslations")]
[Index("HtmlTemplateId", "Culture", Name = "UK_hcc_HtmlTemplateTranslations", IsUnique = true)]
public partial class HccHtmlTemplateTranslations
{
    [Key]
    public long HtmlTemplateTranslationId { get; set; }

    public long HtmlTemplateId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(1024)]
    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? RepeatingSection { get; set; }

    [ForeignKey("HtmlTemplateId")]
    [InverseProperty("HccHtmlTemplateTranslations")]
    public virtual HccHtmlTemplates HtmlTemplate { get; set; } = null!;
}
