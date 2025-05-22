using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_MailingList")]
public partial class HccMailingList
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    public bool Private { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [InverseProperty("List")]
    public virtual ICollection<HccMailingListMember> HccMailingListMember { get; set; } = new List<HccMailingListMember>();
}
