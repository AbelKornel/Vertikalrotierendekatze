using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("CultureCode", Name = "IX_Languages", IsUnique = true)]
public partial class Languages
{
    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(50)]
    public string CultureCode { get; set; } = null!;

    [StringLength(200)]
    public string CultureName { get; set; } = null!;

    [StringLength(50)]
    public string? FallbackCulture { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [InverseProperty("Language")]
    public virtual ICollection<PortalLanguages> PortalLanguages { get; set; } = new List<PortalLanguages>();
}
