using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_SubscriptionTypes")]
[Index("SubscriptionName", Name = "IX_CoreMessaging_SubscriptionTypes_SubscriptionName", IsUnique = true)]
public partial class CoreMessagingSubscriptionTypes
{
    [Key]
    public int SubscriptionTypeId { get; set; }

    [StringLength(50)]
    public string SubscriptionName { get; set; } = null!;

    [StringLength(50)]
    public string FriendlyName { get; set; } = null!;

    public int? DesktopModuleId { get; set; }

    [InverseProperty("SubscriptionType")]
    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscriptions>();
}
