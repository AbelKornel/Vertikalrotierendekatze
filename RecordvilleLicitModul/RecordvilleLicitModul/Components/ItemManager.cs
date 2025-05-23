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

using DotNetNuke.Data;
using DotNetNuke.Framework;
using LicitModul.DnnRecordvilleLicitModul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Hotcakes.Commerce;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Extensions;
using Hotcakes.Commerce.Orders;
using Hotcakes.Commerce.Urls;
using Hotcakes.CommerceDTO;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Catalog;
using System.Runtime.InteropServices;


namespace LicitModul.DnnRecordvilleLicitModul.Components
{
    internal interface IItemManager
    {
        void CreateItem(Item t);
        void DeleteItem(string itemId, int moduleId);
        void DeleteItem(Item t);
        IEnumerable<Item> GetItems(int moduleId);
        Item GetItem(string itemId, int moduleId);
        void UpdateItem(Item t);
    }

    public class AuctionGenerator
    {
        private static readonly AuctionGenerator _instance = new AuctionGenerator();

        public static AuctionGenerator Instance => _instance;

        private AuctionGenerator() { }

        public void CreateBid(Auction bid)
        {
            using (var context = DataContext.Instance())
            {
                var repository = context.GetRepository<Auction>();
                repository.Insert(bid);
            }
        }

        public IEnumerable<Auction> GetBidsByItemId(string itemId)
        {
            using (var context = DataContext.Instance())
            {
                var repository = context.GetRepository<Auction>();
                return repository.Get(itemId);
            }
        }
    }

    internal class AuctionManager
    {
        private static readonly AuctionManager _instance = new AuctionManager();
        public static AuctionManager Instance => _instance;
        private readonly Api _api;

        private AuctionManager()
        {
            string storeUrl = "http://rendfejl1018.northeurope.cloudapp.azure.com";
            string apiKey = "1-4496a442-8767-4aa7-ad10-c0c8263098f1";
            _api = new Api(storeUrl, apiKey);
        }

        public IEnumerable<Item> GetItems(int moduleId)
        {
            var response = _api.ProductsFindAll();

            if (response == null || response.Content == null)
            {
                return new List<Item>();
            }

            var auctionProducts = response.Content
                .Where(p => p.IsAvailableForSale == false)
                .Select(p =>
                {
                    var bids = AuctionGenerator.Instance.GetBidsByItemId(p.Bvin) ?? new List<Auction>();
                    var highestBid = bids.OrderByDescending(b => b.Amount).FirstOrDefault();

                    return new Item
                    {
                        ItemId = p.Bvin,
                        Sku = p.Sku,
                        ItemName = p.ProductName,
                        ItemDescription = p.LongDescription,
                        ImageUrl = p.ImageFileMedium,
                        StartingPrice = p.SitePrice,
                        AuctionEndTime = GetOrGenerateAuctionEndTime(p.Bvin),
                        MinimumBidIncrement = p.SitePrice * 0.1m,
                        HighestPrice = highestBid?.Amount,
                        HighestUserId = highestBid?.UserId,
                        ModuleId = moduleId
                    };
                })
                .ToList();

            return auctionProducts;
        }


        public Item GetItem(string itemId, int moduleId)
        {
            var response = _api.ProductsFind(itemId);

            if (response == null || response.Content == null)
            {
                return null;
            }

            var p = response.Content;
            var bids = AuctionGenerator.Instance.GetBidsByItemId(p.Bvin) ?? new List<Auction>();
            var highestBid = bids.OrderByDescending(b => b.Amount).FirstOrDefault();

            return new Item
            {
                ItemId = p.Bvin,
                Sku = p.Sku,
                ItemName = p.ProductName,
                ItemDescription = p.LongDescription,
                ImageUrl = p.ImageFileMedium,
                StartingPrice = p.SitePrice,
                AuctionEndTime = GetOrGenerateAuctionEndTime(p.Bvin),
                MinimumBidIncrement = p.SitePrice * 0.1m,
                HighestPrice = highestBid?.Amount,
                HighestUserId = highestBid?.UserId,
                ModuleId = moduleId
            };
        }




        public void CreateItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Insert(t);
            }
        }

        public void UpdateItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Update(t);
            }
        }

        public void DeleteItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Delete(t);
            }
        }

        public void DeleteItem(string itemId, int moduleId)
        {
            var t = GetItem(itemId, moduleId);
            DeleteItem(t);
        }

        private static readonly Dictionary<string, DateTime> auctionEndTimes = new Dictionary<string, DateTime>();




        private static readonly bool IsTestMode = false;

        private DateTime GetOrGenerateAuctionEndTime(string itemId)
        {
            if (auctionEndTimes.ContainsKey(itemId))
            {
                return auctionEndTimes[itemId];
            }

            DateTime endTime;
            if (IsTestMode)
            {
                endTime = DateTime.UtcNow.AddSeconds(20);
            }
            else
            {
                var random = new Random(itemId.GetHashCode());
                int days = random.Next(5, 21);
                endTime = DateTime.UtcNow.Date.AddDays(days).AddHours(20);
            }

            auctionEndTimes[itemId] = endTime;
            return endTime;
        }



    }

}