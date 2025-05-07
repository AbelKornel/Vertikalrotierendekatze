using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace LicitModul.DnnRecordvilleLicitModul.Models
{
    [TableName("RecordvilleLicitModul_Auctions")]
    [PrimaryKey("AuctionId", AutoIncrement = true)]
    [Cacheable("PlaceBid", CacheItemPriority.Default, 20)]
    [Scope("ItemId")]
    public class Auction
    {
        public int AuctionId { get; set; } = -1;
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime AuctionTime { get; set; } = DateTime.UtcNow;
    }
}
