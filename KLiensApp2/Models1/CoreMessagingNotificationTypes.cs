using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_NotificationTypes")]
[Index("Name", Name = "IX_CoreMessaging_NotificationTypes", IsUnique = true)]
public partial class CoreMessagingNotificationTypes
{
    [Key]
    [Column("NotificationTypeID")]
    public int NotificationTypeId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(2000)]
    public string? Description { get; set; }

    [Column("TTL")]
    public int? Ttl { get; set; }

    [Column("DesktopModuleID")]
    public int? DesktopModuleId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsTask { get; set; }

    [InverseProperty("NotificationType")]
    public virtual ICollection<CoreMessagingMessages> CoreMessagingMessages { get; set; } = new List<CoreMessagingMessages>();

    [InverseProperty("NotificationType")]
    public virtual ICollection<CoreMessagingNotificationTypeActions> CoreMessagingNotificationTypeActions { get; set; } = new List<CoreMessagingNotificationTypeActions>();

    [ForeignKey("DesktopModuleId")]
    [InverseProperty("CoreMessagingNotificationTypes")]
    public virtual DesktopModules? DesktopModule { get; set; }
}
