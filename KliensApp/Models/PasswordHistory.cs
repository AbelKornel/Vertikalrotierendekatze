using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class PasswordHistory
{
    [Key]
    [Column("PasswordHistoryID")]
    public int PasswordHistoryId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(128)]
    public string Password { get; set; } = null!;

    [StringLength(128)]
    public string PasswordSalt { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PasswordHistory")]
    public virtual Users User { get; set; } = null!;
}
