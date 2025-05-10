using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using KliensApp.Data;
using KliensApp.Models;
using System;
using System.Linq;

namespace KliensApp.UnitTests
{
    // Ez az osztály az adatbázis kapcsolatot teszteli
    [TestFixture]
    public class KliensDbContextTests
    {
        // Ezt használjuk az adatbázis-opcióhoz
        private DbContextOptions<KliensDbContext> _options;

        // Minden teszt előtt beállítja az adatbázist
        [SetUp]
        public void Setup()
        {
            // Memóriában lévő adatbázist használunk teszt célokra
            // Ez nem igazi adatbázis, csak a memóriában létezik
            _options = new DbContextOptionsBuilder<KliensDbContext>()
                .UseInMemoryDatabase(databaseName: "TestAdatbazis")
                .Options;
        }

        // Ez a ProductsToOrder táblát teszteli
        [Test]
        public void TestProductsToOrderDbSet()
        {
            // Létrehozunk egy új adatbázis kapcsolatot
            var context = new KliensDbContext(_options);
            
            // Megnézzük, hogy a ProductsToOrder tábla létezik-e
            Assert.That(context.ProductsToOrder, Is.Not.Null, "A ProductsToOrder tábla nem létezik");
        }

        // Ez az OrderedProducts táblát teszteli
        [Test]
        public void TestOrderedProductsDbSet()
        {
            // Létrehozunk egy új adatbázis kapcsolatot
            var context = new KliensDbContext(_options);
            
            // Megnézzük, hogy az OrderedProducts tábla létezik-e
            Assert.That(context.OrderedProducts, Is.Not.Null, "Az OrderedProducts tábla nem létezik");
        }

        // Ez a HccSearchQuery táblát teszteli
        [Test]
        public void TestHccSearchQueryDbSet()
        {
            // Létrehozunk egy új adatbázis kapcsolatot
            var context = new KliensDbContext(_options);
            
            // Megnézzük, hogy a HccSearchQuery tábla létezik-e
            Assert.That(context.HccSearchQuery, Is.Not.Null, "A HccSearchQuery tábla nem létezik");
        }
    }
} 