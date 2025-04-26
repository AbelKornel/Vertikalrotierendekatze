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


namespace LicitModul.DnnRecordvilleLicitModul.Controllers
{
    [DnnHandleError]
    public class ItemController : DnnController
    {

        public ActionResult Delete(int itemId)
        {
            AuctionManager.Instance.DeleteItem(itemId, ModuleContext.ModuleId);
            return RedirectToDefaultRoute();
        }

        public ActionResult Edit(int itemId = -1)
        {
            DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins);

            var userlist = UserController.GetUsers(PortalSettings.PortalId);
            var users = from user in userlist.Cast<UserInfo>().ToList()
                        select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

            ViewBag.Users = users;

            var item = (itemId == -1)
                 ? new Item { ModuleId = ModuleContext.ModuleId }
                 : AuctionManager.Instance.GetItem(itemId, ModuleContext.ModuleId);

            return View(item);
        }


        [HttpPost]
        public JsonResult PlaceBid(int itemId, int userId, decimal bidAmount)
        {
            try
            {
                var item = AuctionManager.Instance.GetItem(itemId, ModuleContext.ModuleId);
                if (item == null)
                {
                    return Json(new { newPrice = item.StartingPrice });
                }

                decimal currentPrice = item.HighestPrice ?? item.StartingPrice;
                if (bidAmount < currentPrice + item.MinimumBidIncrement)
                {
                    return Json(new { newPrice = item.HighestPrice });
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
                return Json(new { newPrice = item.HighestPrice });
            }
            catch (Exception ex)
            {
                return Json(new { newPrice = 0 });
            }
        }

        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public ActionResult Index()
        {

            ViewBag.ModuleId = ModuleContext.ModuleId;
            var items = AuctionManager.Instance.GetItems(ModuleContext.ModuleId);
            return View(items);
        }

        public ActionResult Details(int itemId)
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

            return View("Details", item);
        }




    }
}