using NUnit.Framework;
using System;
using System.Linq;

namespace KLiensApp2.UnitTests
{
    [TestFixture]
    public class OrderedProductsTests
    {
        // Tesztelünk egy új termék létrehozását
        [Test]
        public void OrderedProducts_Létrehozás()
        {
            // Arrange és Act: itt direkt egybe vettük, nincs sok miden történik
            OrderedProducts orderedProduct = new OrderedProducts();

            // Assert: Ellenőrizzük, hogy létrejött az objektum
            Assert.That(orderedProduct, Is.Not.Null, "Az objektumot nem sikerült létrehozni!");
        }

        // Teszteljük, hogy a ProductName property jól működik
        // Ez egy egyszerű set-get teszt, a gyakorlatban elég alapvető, de kezdőként nagyon hasznos látni
        [Test]
        public void OrderedProducts_ProductName_Beállítás_És_Lekérdezés()
        {
            // Arrange: Létrehozunk egy új terméket és egy elvárt termék nevet
            OrderedProducts orderedProduct = new OrderedProducts();
            string expectedProductName = "Teszt termék";

            // Act: Beállítjuk a termék nevét
            orderedProduct.ProductName = expectedProductName;
            string actualProductName = orderedProduct.ProductName;

            // Assert: Ellenőrizzük, hogy a termék neve helyes
            Assert.That(actualProductName, Is.EqualTo(expectedProductName), "A termék neve nem egyezik a beállított értékkel!");
        }

        // Teszteljük, hogy a Quantity property jól működik
        [Test]
        public void OrderedProducts_Quantity_Beállítás_És_Lekérdezés()
        {
            // Arrange: Létrehozunk egy terméket és egy elvárt mennyiséget
            OrderedProducts orderedProduct = new OrderedProducts();
            int expectedQuantity = 5;

            // Act: Beállítjuk a mennyiséget
            orderedProduct.Quantity = expectedQuantity;
            int? actualQuantity = orderedProduct.Quantity;

            // Assert: Ellenőrizzük, hogy a mennyiség helyes
            Assert.That(actualQuantity, Is.EqualTo(expectedQuantity), "A mennyiség nem egyezik a beállított értékkel!");
        }

        // Teszteljük, hogy a Quantity property nullable (opcionálisan lehet null)
        [Test]
        public void OrderedProducts_Quantity_Lehet_Null()
        {
            // Arrange: Létrehozunk egy új terméket
            OrderedProducts orderedProduct = new OrderedProducts();

            // Act: Beállítjuk a mennyiséget null-ra
            orderedProduct.Quantity = null;

            // Assert: Ellenőrizzük, hogy a mennyiség tényleg null
            Assert.That(orderedProduct.Quantity, Is.Null, "A Quantity property nem lehet null!");
        }
    }
} 