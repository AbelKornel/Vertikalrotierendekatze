using LicitModul.DnnRecordvilleLicitModul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LicitModul.DnnRecordvilleLicitModul.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            var dataProvider = new AuctionDataProvider();
            var activeAuctions = dataProvider.GetActiveAuctions();
            if (activeAuctions == null || !activeAuctions.Any())
            {
                // Ha nincs aukció, akkor kezeljük a null értéket, vagy a hibaüzenetet jelenítjük meg
                ViewBag.ErrorMessage = "Nincsenek elérhető aukciók.";
                return View();
            }
            return View("~/DesktopModules/MVC/RecordvilleLicitModul/Views/Auction/Index.cshtml", activeAuctions);
        }


        // GET: Auction/Details/5
        public ActionResult Details(int id)
        {
            var dataProvider = new AuctionDataProvider();
            var auction = dataProvider.GetActiveAuctions().FirstOrDefault(a => a.Id == id);

            if (auction == null)
            {
                ViewBag.ErrorMessage = "A kiválasztott aukció nem található.";
                return View("Error"); // Error nézetre irányítás, ha az aukció nem található
            }

            return View(auction);
        }

        // GET: Auction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auction/Create
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dataProvider = new AuctionDataProvider();
                    dataProvider.CreateAuction(auction);
                    return RedirectToAction("Index");
                }
                return View(auction);
            }
            catch
            {
                return View();
            }
        }

        // GET: Auction/Edit/5
        public ActionResult Edit(int id)
        {
            var dataProvider = new AuctionDataProvider();
            var auction = dataProvider.GetActiveAuctions().FirstOrDefault(a => a.Id == id);
            return View(auction);
        }

        // POST: Auction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Auction auction)
        {
            try
            {
                var dataProvider = new AuctionDataProvider();
                dataProvider.CreateAuction(auction); // Update the auction data
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Auction/Delete/5
        public ActionResult Delete(int id)
        {
            var dataProvider = new AuctionDataProvider();
            var auction = dataProvider.GetActiveAuctions().FirstOrDefault(a => a.Id == id);
            return View(auction);
        }

        // POST: Auction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dataProvider = new AuctionDataProvider();
                // Delete logic here (e.g., delete from DB)
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Auction/PlaceBid/5
        [HttpPost]
        public ActionResult PlaceBid(int auctionId, decimal bidAmount)
        {
            var dataProvider = new AuctionDataProvider();
            var auction = dataProvider.GetActiveAuctions().FirstOrDefault(a => a.Id == auctionId);

            if (auction != null && bidAmount >= auction.CurrentBid + auction.MinimumBidIncrement)
            {
                dataProvider.PlaceBid(auctionId, bidAmount); // Update the auction with the new bid
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "A licit nem érheti el az aktuális ajánlatot és a minimális növekedést!";
                return View("Details", new { id = auctionId });
            }
        }
    }
}

