using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("CookieValue", Name = "IX_AuthCookies_CookieValue", IsUnique = true)]
public partial class AuthCookies
{
    [Key]
    public int CookieId { get; set; }

    [StringLength(200)]
    public string CookieValue { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ExpiresOn { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
