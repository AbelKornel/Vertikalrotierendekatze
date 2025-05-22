using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_Messages")]
[Index("MessageId", "PortalId", "NotificationTypeId", "ExpirationDate", Name = "IX_CoreMessaging_Messages_Send_MessageID_PortalID_NotificationTypeID_ExpirationDate", IsUnique = true, IsDescending = new[] { false, false, false, true })]
[Index("SenderUserId", "CreatedOnDate", Name = "IX_CoreMessaging_Messages_SenderUserID", IsDescending = new[] { false, true })]
public partial class CoreMessagingMessages
{
    [Key]
    [Column("MessageID")]
    public int MessageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [Column("NotificationTypeID")]
    public int? NotificationTypeId { get; set; }

    [StringLength(2000)]
    public string? To { get; set; }

    [StringLength(200)]
    public string? From { get; set; }

    [StringLength(400)]
    public string? Subject { get; set; }

    public string? Body { get; set; }

    [Column("ConversationID")]
    public int? ConversationId { get; set; }

    public bool? ReplyAllAllowed { get; set; }

    [Column("SenderUserID")]
    public int? SenderUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(200)]
    public string? Context { get; set; }

    public bool? IncludeDismissAction { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [InverseProperty("Message")]
    public virtual ICollection<CoreMessagingMessageAttachments> CoreMessagingMessageAttachments { get; set; } = new List<CoreMessagingMessageAttachments>();

    [InverseProperty("Message")]
    public virtual ICollection<CoreMessagingMessageRecipients> CoreMessagingMessageRecipients { get; set; } = new List<CoreMessagingMessageRecipients>();

    [ForeignKey("NotificationTypeId")]
    [InverseProperty("CoreMessagingMessages")]
    public virtual CoreMessagingNotificationTypes? NotificationType { get; set; }
}
