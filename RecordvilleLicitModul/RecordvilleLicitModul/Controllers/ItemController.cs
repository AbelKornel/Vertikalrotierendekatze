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

using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.UI.Containers;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using LicitModul.DnnRecordvilleLicitModul.Components;
using LicitModul.DnnRecordvilleLicitModul.Models;
using System;
using System.Linq;
using System.Web.Compilation;
using System.Web.Mvc;
using Newtonsoft.Json;
using Hotcakes.Commerce;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Orders;
using Hotcakes.Commerce.Storage;
using Hotcakes.Commerce.Extensions;
using Hotcakes.Commerce.Urls;
using System.Collections.Generic;
using DotNetNuke.Data;


namespace LicitModul.DnnRecordvilleLicitModul.Controllers
{
    [DnnHandleError]
    public class ItemController : DnnController
    {

        public ActionResult Delete(string itemId)
        {
            AuctionManager.Instance.DeleteItem(itemId, ModuleContext.ModuleId);
            return RedirectToDefaultRoute();
        }

        public ActionResult Edit(string itemId)
        {
            DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins);

            var userlist = UserController.GetUsers(PortalSettings.PortalId);
            var users = from user in userlist.Cast<UserInfo>().ToList()
                        select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

            ViewBag.Users = users;

            var item = string.IsNullOrEmpty(itemId)
            ? new Item { ModuleId = ModuleContext.ModuleId }
            : AuctionManager.Instance.GetItem(itemId, ModuleContext.ModuleId);


            return View(item);
        }


        [HttpPost]
        public JsonResult PlaceBid(string itemId, int userId, decimal bidAmount)
        {
            try
            {
                var item = AuctionManager.Instance.GetItem(itemId, ModuleContext.ModuleId);
                if (item == null)
                {
                    return Json(new { success = false, newPrice = 0 });
                }

                decimal currentPrice = item.HighestPrice ?? item.StartingPrice;
                if (bidAmount < currentPrice + item.MinimumBidIncrement)
                {
                    return Json(new { success = false, newPrice = currentPrice });
                }

                var bid = new Auction
                {
                    UserId = userId,
                    ItemId = itemId,
                    Amount = bidAmount,
                    AuctionTime = DateTime.UtcNow
                };

                AuctionGenerator.Instance.CreateBid(bid);

                item.HighestPrice = bidAmount;
                item.HighestUserId = userId;
                AuctionManager.Instance.UpdateItem(item);

                return Json(new { success = true, newPrice = item.HighestPrice });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, newPrice = 0 });
            }
        }



        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public ActionResult Index()
        {
            var hccApp = HotcakesApplication.Current;

            var items1 = AuctionManager.Instance.GetItems(ModuleContext.ModuleId);

            foreach (var item in items1)
            {
                if (item.AuctionEndTime.HasValue &&
                    item.AuctionEndTime.Value < DateTime.UtcNow &&
                    item.HighestUserId.HasValue &&
                    item.HighestPrice.HasValue)
                {
                    var product = hccApp.CatalogServices.Products.Find(item.ItemId);
                    if (product != null && product.SitePrice != item.HighestPrice.Value)
                    {
                        product.SitePrice = item.HighestPrice.Value;
                        product.Status = Hotcakes.Commerce.Catalog.ProductStatus.Active;
                        hccApp.CatalogServices.Products.Update(product);
                    }
                }
            }


            var userId = UserController.Instance.GetCurrentUserInfo().UserID;
            ViewBag.UserId = userId;

            ViewBag.ModuleId = ModuleContext.ModuleId;
            var items = AuctionManager.Instance.GetItems(ModuleContext.ModuleId);
            return View(items);
        }

        public ActionResult Details(string itemId)
        {
            var item = AuctionManager.Instance.GetItem(itemId, ModuleContext.ModuleId);
            if (item == null)
            {
                return HttpNotFound("A termék nem található.");
            }

            item.RecentBids = AuctionGenerator.Instance.GetBidsByItemId(itemId);
            ViewBag.ModuleId = ModuleContext.ModuleId;
            ViewBag.TabId = ModuleContext.TabId;
            ViewBag.ItemId = itemId;
            ViewBag.UserId = UserController.Instance.GetCurrentUserInfo().UserID;
            ViewBag.MinimumBidIncrement = item.MinimumBidIncrement;
            ViewBag.CurrentPrice = item.HighestPrice ?? item.StartingPrice;
            ViewBag.AuctionEndTime = item.AuctionEndTime;
            ViewBag.HighestUserId = item.HighestUserId;

            return View("Details", item);
        }

        /*
        public class UserContactInfo
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public bool MarketingConsent { get; set; }
            public DateTime SubmittedAt { get; set; }
        }

        
        [HttpGet]
        public ActionResult WinningBids(int userId)
        {
            var winningItems = AuctionManager.Instance.GetItems(ModuleContext.ModuleId)
                .Where(item => item.AuctionEndTime.HasValue && item.AuctionEndTime.Value < DateTime.Now)
                .Where(item => item.HighestUserId == userId)
                .ToList();

            if (winningItems.Any())
            {
                return View(winningItems);
            }
            else
            {
                ViewBag.Message = "Sajnáljuk, nem nyert licitet.";
                return View(new List<Item>());
            }
        }
        */

    }
}
