using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace LicitModul.DnnRecordvilleLicitModul.Models
{
    [TableName("RecordvilleLicitModul_Auctions")]
    //setup the primary key for table
    [PrimaryKey("AuctionId", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Auctions", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
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
