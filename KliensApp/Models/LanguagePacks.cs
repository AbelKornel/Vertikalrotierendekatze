using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("LanguageId", "PackageId", Name = "IX_LanguagePacks", IsUnique = true)]
public partial class LanguagePacks
{
    [Key]
    [Column("LanguagePackID")]
    public int LanguagePackId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [Column("DependentPackageID")]
    public int DependentPackageId { get; set; }

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

    [ForeignKey("PackageId")]
    [InverseProperty("LanguagePacks")]
    public virtual Packages Package { get; set; } = null!;
}
