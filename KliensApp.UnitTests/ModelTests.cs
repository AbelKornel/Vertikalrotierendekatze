using NUnit.Framework;
using KliensApp.Models;
using System;

namespace KliensApp.UnitTests
{
    // Ez az osztály a ProductsToOrder modellünket teszteli
    [TestFixture]
    public class ProductsToOrderTests
    {
        // Itt megnézzük, hogy jól beállítódnak-e a tulajdonságok
        [Test]
        public void TestProductsToOrderProperties()
        {
            // Létrehozunk egy példát, amiben beállítjuk az értékeket
            var product = new ProductsToOrder();
            product.Id = 1;
            product.Phrase = "Teszt termék";

            // Megnézzük, hogy tényleg az lett-e, amit beállítottunk
            Assert.That(product.Id, Is.EqualTo(1));         // Ez az Id-t ellenőrzi
            Assert.That(product.Phrase, Is.EqualTo("Teszt termék")); // Ez a Phrase-t ellenőrzi
        }

        // Itt az alapértelmezett értéket nézzük az Id-ra
        [Test]
        public void TestProductsToOrderIdDefaultValue()
        {
            // Csinálunk egy üres példányt
            var product = new ProductsToOrder();

            // Az Id alapból 0 kell legyen
            Assert.That(product.Id, Is.EqualTo(0));
        }

        // Itt megnézzük, hogy a Phrase null-e alapból
        [Test]
        public void TestProductsToOrderPhraseNullable()
        {
            // Csinálunk egy üres példányt
            var product = new ProductsToOrder();

            // A Phrase null kell legyen
            Assert.That(product.Phrase, Is.Null);
        }
    }

    // Ez az osztály az OrderedProducts modellünket teszteli
    [TestFixture]
    public class OrderedProductsTests
    {
        // Itt megnézzük, hogy jól beállítódnak-e a tulajdonságok
        [Test]
        public void TestOrderedProductsProperties()
        {
            // Létrehozunk egy példát és beállítjuk az értékeket
            var orderedProduct = new OrderedProducts();
            orderedProduct.OrderId = 1;
            orderedProduct.ProductName = "Teszt termék";
            orderedProduct.Quantity = 5;

            // Megnézzük, hogy tényleg azok lettek-e, amiket beállítottunk
            Assert.That(orderedProduct.OrderId, Is.EqualTo(1));         // Ez az OrderId-t ellenőrzi
            Assert.That(orderedProduct.ProductName, Is.EqualTo("Teszt termék")); // Ez a ProductName-t ellenőrzi
            Assert.That(orderedProduct.Quantity, Is.EqualTo(5));        // Ez a Quantity-t ellenőrzi
        }

        // Itt az alapértelmezett értéket nézzük az OrderId-ra
        [Test]
        public void TestOrderedProductsIdDefaultValue()
        {
            // Csinálunk egy üres példányt
            var orderedProduct = new OrderedProducts();

            // Az OrderId alapból 0 kell legyen
            Assert.That(orderedProduct.OrderId, Is.EqualTo(0));
        }

        // Itt megnézzük, hogy a Quantity null-e alapból
        [Test]
        public void TestOrderedProductsQuantityNullable()
        {
            // Csinálunk egy üres példányt
            var orderedProduct = new OrderedProducts();

            // A Quantity null kell legyen
            Assert.That(orderedProduct.Quantity, Is.Null);
        }
    }
} 