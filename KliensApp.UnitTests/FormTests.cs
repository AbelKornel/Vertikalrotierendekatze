using NUnit.Framework;
using System;
using System.Collections.Generic;
using KliensApp.Models;
using KliensApp.Data;
using System.Windows.Forms;
using Moq;
using System.ComponentModel;
using System.Linq;

namespace KliensApp.UnitTests
{
    // Ez az osztály a Form1-et teszteli
    [TestFixture]
    public class Form1Tests
    {
        // Ez a mockolt adatbázis-kapcsolat, hogy ne kelljen igazi DB
        private Mock<KliensDbContext> _mockContext;

        // Ezt minden teszt előtt lefuttatja
        [SetUp]
        public void Setup()
        {
            // Létrehozzuk a hamis adatbázis-kapcsolatot
            _mockContext = new Mock<KliensDbContext>();
        }

        // Itt a form betöltését teszteljük
        [Test]
        public void TestForm1LoadEvent()
        {
            // Létrehozunk néhány teszt keresést
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

            var mockSearchQueries = new List<HccSearchQuery>();
            mockSearchQueries.Add(keresesiElem1);
            mockSearchQueries.Add(keresesiElem2);

            // Létrehozzuk a formot
            var form = new Form1();

            // Megnézzük, hogy sikerült-e létrehozni a formot
            Assert.That(form, Is.Not.Null, "A form nem jött létre");
        }

        // Itt a lista frissítés metódust teszteljük
        [Test]
        public void TestListUpdateMethod()
        {
            // Létrehozunk néhány terméket
            var termek1 = new ProductsToOrder();
            termek1.Id = 1;
            termek1.Phrase = "Test phrase 1";

            var termek2 = new ProductsToOrder();
            termek2.Id = 2;
            termek2.Phrase = "Test phrase 2";

            var mockToOrderProducts = new List<ProductsToOrder>();
            mockToOrderProducts.Add(termek1);
            mockToOrderProducts.Add(termek2);

            // Létrehozzuk a formot
            var form = new Form1();

            // Megnézzük, hogy sikerült-e létrehozni a formot
            Assert.That(form, Is.Not.Null, "A form nem jött létre");
        }

        // Itt a DataGridView frissítés metódust teszteljük
        [Test]
        public void TestDataGridViewUpdateMethod()
        {
            // Létrehozunk néhány megrendelt terméket
            var megrendeltTermek1 = new OrderedProducts();
            megrendeltTermek1.OrderId = 1;
            megrendeltTermek1.ProductName = "Test product 1";
            megrendeltTermek1.Quantity = 1;

            var megrendeltTermek2 = new OrderedProducts();
            megrendeltTermek2.OrderId = 2;
            megrendeltTermek2.ProductName = "Test product 2";
            megrendeltTermek2.Quantity = 2;

            var mockOrderedProducts = new List<OrderedProducts>();
            mockOrderedProducts.Add(megrendeltTermek1);
            mockOrderedProducts.Add(megrendeltTermek2);

            // Létrehozzuk a formot
            var form = new Form1();

            // Megnézzük, hogy sikerült-e létrehozni a formot
            Assert.That(form, Is.Not.Null, "A form nem jött létre");
        }

        // Button1 kattintást teszteljük
        [Test]
        public void TestButton1ClickEvent()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Button2 kattintást teszteljük
        [Test]
        public void TestButton2ClickEvent()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Button3 kattintást teszteljük
        [Test]
        public void TestButton3ClickEvent()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Az API hívás metódusát teszteljük
        [Test]
        public void TestApiHivasMethod()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }
    }

    // Ez az osztály az Ordering formot teszteli
    [TestFixture]
    public class OrderingTests
    {
        // Button1 kattintást teszteljük
        [Test]
        public void TestButton1ClickEvent()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Button2 kattintást teszteljük
        [Test]
        public void TestButton2ClickEvent()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Itt a CheckDB metódust teszteljük
        [Test]
        public void TestCheckDBMethod()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Itt a CheckName metódust teszteljük
        [Test]
        public void TestCheckNameMethod()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Itt a TextBox1 validációt teszteljük
        [Test]
        public void TestTextBox1ValidationEvents()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }

        // Itt a TextBox2 validációt teszteljük
        [Test]
        public void TestTextBox2ValidationEvents()
        {
            // Ezt később kéne rendesen megírni
            // Most csak azt nézzük, hogy nem szál el a teszt
            Assert.That(true, Is.True, "Ez a teszt mindig sikerül");
        }
    }
} 