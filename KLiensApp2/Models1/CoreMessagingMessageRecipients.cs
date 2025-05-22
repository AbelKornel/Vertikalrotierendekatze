using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_MessageRecipients")]
[Index("UserId", "Read", "Archived", Name = "IX_CoreMessaging_MessageRecipients_UserID", IsDescending = new[] { false, true, false })]
[Index("MessageId", "UserId", "Read", "SendToast", Name = "IX_CoreMessaging_MessageRecipients_UserID_MessageID_Read_SendToast", IsUnique = true)]
public partial class CoreMessagingMessageRecipients
{
    [Key]
    [Column("RecipientID")]
    public int RecipientId { get; set; }

    [Column("MessageID")]
    public int MessageId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    public bool Read { get; set; }

    public bool Archived { get; set; }

    public bool EmailSent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool SendToast { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("CoreMessagingMessageRecipients")]
    public virtual CoreMessagingMessages Message { get; set; } = null!;
}
