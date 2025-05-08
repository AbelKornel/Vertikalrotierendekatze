using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Product")]
[Index("ManufacturerId", Name = "IX_hcc_Product_ManufacturerId")]
[Index("Status", "Bvin", Name = "IX_hcc_Product_Status")]
[Index("VendorId", Name = "IX_hcc_Product_VendorId")]
[Index("StoreId", "Sku", Name = "UK_hcc_Product", IsUnique = true)]
public partial class HccProduct
{
    public long Id { get; set; }

    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column("SKU")]
    [StringLength(50)]
    public string Sku { get; set; } = null!;

    public Guid? ProductTypeId { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ListPrice { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal SitePrice { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal SiteCost { get; set; }

    public int TaxExempt { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TaxClass { get; set; } = null!;

    public int NonShipping { get; set; }

    public int ShipSeparately { get; set; }

    public int ShippingMode { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ShippingWeight { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ShippingLength { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ShippingWidth { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ShippingHeight { get; set; }

    public int Status { get; set; }

    [StringLength(512)]
    public string ImageFileSmall { get; set; } = null!;

    [StringLength(512)]
    public string ImageFileMedium { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    public int MinimumQty { get; set; }

    [Column("ManufacturerID")]
    public Guid? ManufacturerId { get; set; }

    [Column("VendorID")]
    public Guid? VendorId { get; set; }

    public int GiftWrapAllowed { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ExtraShipFee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [StringLength(512)]
    public string TemplateName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PreContentColumnId { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PostContentColumnId { get; set; } = null!;

    public string RewriteUrl { get; set; } = null!;

    public string CustomProperties { get; set; } = null!;

    [Column(TypeName = "numeric(18, 10)")]
    public decimal GiftWrapPrice { get; set; }

    public long StoreId { get; set; }

    public bool Featured { get; set; }

    public bool? AllowReviews { get; set; }

    public int OutOfStockMode { get; set; }

    public bool IsAvailableForSale { get; set; }

    public bool IsUserPrice { get; set; }

    public bool HideQty { get; set; }

    public bool IsSearchable { get; set; }

    public bool IsBundle { get; set; }

    public bool IsGiftCard { get; set; }

    public bool IsRecurring { get; set; }

    public int? RecurringInterval { get; set; }

    public int? RecurringIntervalType { get; set; }

    public int ShippingCharge { get; set; }

    public bool AllowUpcharge { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal UpchargeAmount { get; set; }

    [Column("UpchargeUnit ")]
    [StringLength(255)]
    public string? UpchargeUnit { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<HccBundledProducts> HccBundledProducts { get; set; } = new List<HccBundledProducts>();

    [InverseProperty("Product")]
    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; set; } = new List<HccCatalogRoles>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductFileXproduct> HccProductFileXproduct { get; set; } = new List<HccProductFileXproduct>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductImage> HccProductImage { get; set; } = new List<HccProductImage>();

    [InverseProperty("ProductBvinNavigation")]
    public virtual ICollection<HccProductInventory> HccProductInventory { get; set; } = new List<HccProductInventory>();

    [InverseProperty("ProductBvinNavigation")]
    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValue { get; set; } = new List<HccProductPropertyValue>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductRelationships> HccProductRelationships { get; set; } = new List<HccProductRelationships>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductReview> HccProductReview { get; set; } = new List<HccProductReview>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductTranslations> HccProductTranslations { get; set; } = new List<HccProductTranslations>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductVolumeDiscounts> HccProductVolumeDiscounts { get; set; } = new List<HccProductVolumeDiscounts>();

    [InverseProperty("Product")]
    public virtual ICollection<HccProductXcategory> HccProductXcategory { get; set; } = new List<HccProductXcategory>();

    [InverseProperty("ProductBvinNavigation")]
    public virtual ICollection<HccProductXoption> HccProductXoption { get; set; } = new List<HccProductXoption>();

    [InverseProperty("Product")]
    public virtual ICollection<HccVariants> HccVariants { get; set; } = new List<HccVariants>();

    [InverseProperty("Product")]
    public virtual ICollection<HccWishListItems> HccWishListItems { get; set; } = new List<HccWishListItems>();

    [ForeignKey("ManufacturerId")]
    [InverseProperty("HccProduct")]
    public virtual HccManufacturer? Manufacturer { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("HccProduct")]
    public virtual HccProductType? ProductType { get; set; }

    [ForeignKey("VendorId")]
    [InverseProperty("HccProduct")]
    public virtual HccVendor? Vendor { get; set; }
}
