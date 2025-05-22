using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_Subscriptions")]
public partial class CoreMessagingSubscriptions
{
    [Key]
    public int SubscriptionId { get; set; }

    public int UserId { get; set; }

    public int? PortalId { get; set; }

    public int SubscriptionTypeId { get; set; }

    [StringLength(255)]
    public string? ObjectKey { get; set; }

    public string? ObjectData { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    public int? ModuleId { get; set; }

    public int? TabId { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("CoreMessagingSubscriptions")]
    public virtual Modules? Module { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("CoreMessagingSubscriptions")]
    public virtual Portals? Portal { get; set; }

    [ForeignKey("SubscriptionTypeId")]
    [InverseProperty("CoreMessagingSubscriptions")]
    public virtual CoreMessagingSubscriptionTypes SubscriptionType { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("CoreMessagingSubscriptions")]
    public virtual Users User { get; set; } = null!;
}
