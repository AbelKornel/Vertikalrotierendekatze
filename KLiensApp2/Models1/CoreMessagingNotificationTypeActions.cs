using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_NotificationTypeActions")]
[Index("NotificationTypeId", Name = "IX_CoreMessaging_NotificationTypeActions")]
public partial class CoreMessagingNotificationTypeActions
{
    [Key]
    [Column("NotificationTypeActionID")]
    public int NotificationTypeActionId { get; set; }

    [Column("NotificationTypeID")]
    public int NotificationTypeId { get; set; }

    [StringLength(100)]
    public string NameResourceKey { get; set; } = null!;

    [StringLength(100)]
    public string? DescriptionResourceKey { get; set; }

    [StringLength(100)]
    public string? ConfirmResourceKey { get; set; }

    public int Order { get; set; }

    [Column("APICall")]
    [StringLength(500)]
    public string Apicall { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("NotificationTypeId")]
    [InverseProperty("CoreMessagingNotificationTypeActions")]
    public virtual CoreMessagingNotificationTypes NotificationType { get; set; } = null!;
}
