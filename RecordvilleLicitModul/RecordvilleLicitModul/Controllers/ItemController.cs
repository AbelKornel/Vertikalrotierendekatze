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
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using LicitModul.DnnRecordvilleLicitModul.Components;
using LicitModul.DnnRecordvilleLicitModul.Models;
using System;
using System.Linq;
using System.Web.Compilation;
using System.Web.Mvc;

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
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public ActionResult Auctions(int ItemId, int UserId, decimal BidAmount)
        {
            var item = AuctionManager.Instance.GetItem(ItemId, ModuleContext.ModuleId);

            if (BidAmount < item.HighestPrice + item.MinimumBidIncrement)
            {
                ModelState.AddModelError("", "Minimum összeg magasabb kell legyen mint a mostani ár plusz a minimum licit");
                return RedirectToAction("Index");
            }

            if (item == null)
            {
                return HttpNotFound("Nincs találat");
            }

            var bid = new Auction
            {
                UserId = UserId,
                ItemId = ItemId,
                Amount = BidAmount,
                AuctionTime = DateTime.UtcNow
            };

            AuctionGenerator.Instance.CreateBid(bid);
            item.HighestPrice = BidAmount;
            AuctionManager.Instance.UpdateItem(item);

            TempData["SuccessMessage"] = "A licit sikeres!";

            return RedirectToAction("Index");
        }
        

        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public ActionResult Index()
        {

            ViewBag.ModuleId = ModuleContext.ModuleId;
            var items = AuctionManager.Instance.GetItems(ModuleContext.ModuleId);
            return View(items);
        }

    }
}
   

