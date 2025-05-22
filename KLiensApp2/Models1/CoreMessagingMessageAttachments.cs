using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_MessageAttachments")]
[Index("MessageId", Name = "IX_CoreMessaging_MessageAttachments_MessageID")]
public partial class CoreMessagingMessageAttachments
{
    [Key]
    [Column("MessageAttachmentID")]
    public int MessageAttachmentId { get; set; }

    [Column("MessageID")]
    public int MessageId { get; set; }

    [Column("FileID")]
    public int? FileId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("CoreMessagingMessageAttachments")]
    public virtual CoreMessagingMessages Message { get; set; } = null!;
}
