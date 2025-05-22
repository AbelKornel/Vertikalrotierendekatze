using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class Authentication
{
    [Key]
    [Column("AuthenticationID")]
    public int AuthenticationId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [StringLength(100)]
    public string AuthenticationType { get; set; } = null!;

    public bool IsEnabled { get; set; }

    [StringLength(250)]
    public string SettingsControlSrc { get; set; } = null!;

    [StringLength(250)]
    public string LoginControlSrc { get; set; } = null!;

    [StringLength(250)]
    public string LogoffControlSrc { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("Authentication")]
    public virtual Packages Package { get; set; } = null!;
}
