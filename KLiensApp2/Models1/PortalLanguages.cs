using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "LanguageId", Name = "IX_PortalLanguages", IsUnique = true)]
public partial class PortalLanguages
{
    [Key]
    [Column("PortalLanguageID")]
    public int PortalLanguageId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsPublished { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("PortalLanguages")]
    public virtual Languages Language { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("PortalLanguages")]
    public virtual Portals Portal { get; set; } = null!;
}
