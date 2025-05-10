using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using KliensApp.Data;
using KliensApp.Models;
using System;
using System.Windows.Forms;

namespace KliensApp.UnitTests
{
    // Ez az osztály a Form1 integrációs tesztjeit tartalmazza
    [TestFixture]
    public class Form1IntegrationTests
    {
        // Ezt használjuk az adatbázis-opcióhoz
        private DbContextOptions<KliensDbContext> _options;

        // Minden teszt előtt beállítja az adatbázist és feltölti adatokkal
        [SetUp]
        public void Setup()
        {
            // Memóriában lévő adatbázist használunk teszt célokra
            // Ez nem igazi adatbázis, csak a memóriában létezik
            _options = new DbContextOptionsBuilder<KliensDbContext>()
                .UseInMemoryDatabase(databaseName: "IntegraciosTestAdatbazis")
                .Options;

            // Most feltöltjük a teszt adatokat az adatbázisba
            var context = new KliensDbContext(_options);

            // 1. Létrehozunk két keresési elemet
            var keresesiElem1 = new HccSearchQuery();
            keresesiElem1.Bvin = "test-bvin-1";
            keresesiElem1.QueryPhrase = "test query 1";
            keresesiElem1.ShopperId = "shopper-1";
            keresesiElem1.LastUpdated = DateTime.Now.AddDays(-1);
            keresesiElem1.StoreId = 1;
            
            var keresesiElem2 = new HccSearchQuery();
            keresesiElem2.Bvin = "test-bvin-2";
            keresesiElem2.QueryPhrase = "test query 2";
            keresesiElem2.ShopperId = "shopper-2";
            keresesiElem2.LastUpdated = DateTime.Now;
            keresesiElem2.StoreId = 2;

            // 2. Hozzáadjuk őket az adatbázishoz
            context.HccSearchQuery.Add(keresesiElem1);
            context.HccSearchQuery.Add(keresesiElem2);

            // 3. Létrehozunk egy rendelendő terméket
            var termek = new ProductsToOrder();
            termek.Phrase = "Teszt kifejezés";
            context.ProductsToOrder.Add(termek);

            // 4. Létrehozunk egy megrendelt terméket
            var megrendeltTermek = new OrderedProducts();
            megrendeltTermek.ProductName = "Megrendelt teszt termék";
            megrendeltTermek.Quantity = 3;
            context.OrderedProducts.Add(megrendeltTermek);

            // 5. Elmentjük az adatbázisba az adatokat
            context.SaveChanges();
        }

        // Ide jöhetnek majd az integrációs tesztek
        // Egyelőre nincsenek megírva
    }
} 