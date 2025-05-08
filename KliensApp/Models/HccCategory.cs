using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Category")]
[Index("ParentId", Name = "IX_hcc_Category")]
public partial class HccCategory
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    public int SortOrder { get; set; }

    [Column("ImageURL")]
    [StringLength(512)]
    public string ImageUrl { get; set; } = null!;

    [Column("BannerImageURL")]
    [StringLength(512)]
    public string BannerImageUrl { get; set; } = null!;

    public int SourceType { get; set; }

    public int DisplaySortOrder { get; set; }

    [Column("CustomPageURL")]
    [StringLength(512)]
    public string CustomPageUrl { get; set; } = null!;

    public int CustomPageNewWindow { get; set; }

    public int ShowInTopMenu { get; set; }

    public int Hidden { get; set; }

    [StringLength(512)]
    public string TemplateName { get; set; } = null!;

    [StringLength(50)]
    public string PostContentColumnId { get; set; } = null!;

    [StringLength(50)]
    public string PreContentColumnId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public string RewriteUrl { get; set; } = null!;

    public int ShowTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; set; } = new List<HccCatalogRoles>();

    [InverseProperty("Category")]
    public virtual ICollection<HccCategoryTranslations> HccCategoryTranslations { get; set; } = new List<HccCategoryTranslations>();

    [InverseProperty("Category")]
    public virtual ICollection<HccProductXcategory> HccProductXcategory { get; set; } = new List<HccProductXcategory>();
}
