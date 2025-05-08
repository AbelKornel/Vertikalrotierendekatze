/*
' Copyright (c) 2025 Vertikalrotierendekatze
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using System;
using System.Collections.Generic;
using System.Web.Caching;

namespace LicitModul.DnnRecordvilleLicitModul.Models
{
    [TableName("RecordvilleLicitModul_Items")]
    [PrimaryKey("ItemId", AutoIncrement = true)]
    [Cacheable("Items", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]
    public class Item
    {
        public int ItemId { get; set; } = -1;
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ImageUrl { get; set; }
        public int ModuleId { get; set; }

        public decimal? HighestPrice { get; set; }
        public int? HighestUserId { get; set; }
        public DateTime? AuctionStartTime { get; set; }
        public DateTime? AuctionEndTime { get; set; }
        public decimal MinimumBidIncrement { get; set; }
        public decimal StartingPrice { get; set; }

        [IgnoreColumn]
        public IEnumerable<Auction> RecentBids { get; set; } = new List<Auction>();
    }
}
