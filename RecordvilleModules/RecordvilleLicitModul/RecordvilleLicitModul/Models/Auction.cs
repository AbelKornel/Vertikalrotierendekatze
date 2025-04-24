using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LicitModul.DnnRecordvilleLicitModul.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentBid { get; set; }
        public decimal MinimumBidIncrement { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
