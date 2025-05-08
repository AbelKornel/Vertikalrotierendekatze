using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_MailingListMember")]
public partial class HccMailingListMember
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [Column("ListID")]
    public long ListId { get; set; }

    [StringLength(255)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(255)]
    public string FirstName { get; set; } = null!;

    [StringLength(255)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [ForeignKey("ListId")]
    [InverseProperty("HccMailingListMember")]
    public virtual HccMailingList List { get; set; } = null!;
}
