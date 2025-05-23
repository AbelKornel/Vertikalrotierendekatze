using NUnit.Framework;
using System;
using System.Linq;

namespace KLiensApp2.UnitTests
{
    [TestFixture]
    public class ProductsToOrderTests
    {
        // Mielőtt bármit is csinálnánk, ellenőrizzük hogy a tesztek működnek-e
        [Test]
        public void TestFuttatás_Ellenőrzése()
        {
            // Arrange: Előkészítünk adatokat a teszthez
            int a = 2;
            int b = 2;

            // Act: Valami műveletet végzünk
            int eredmény = a + b;

            // Assert: Ellenőrizzük, hogy a várt eredményt kaptuk-e
            Assert.That(eredmény, Is.EqualTo(4), "2+2 eredménye 4 kellene hogy legyen!");
        }

        // Egy tesztoszály, ami ellenőrzi a ProductsToOrder osztály tsztályt
        // Ez egy nagyon alap modell, szóval csak az alapvető dolgokat teszteljük
        [Test]
        public void ProductsToOrder_Létrehozás()
        {
            // Arrange: Létrehozunk egy új ProductsToOrder objektumot
            // Ez az alapvető konstruktor teszt, nincs sok értleme, de alapszintűek vagyunk

            // Act: Létrehozzuk az objektumot
            ProductsToOrder productToOrder = new ProductsToOrder();

            // Assert: Ellenőrizzük, hogy nem null
            Assert.That(productToOrder, Is.Not.Null, "Az objektum létrehozása sikertelen volt!");
        }

        [Test]
        public void ProductsToOrder_Phrase_Property_Beállítás_És_Lekérdezés()
        {
            // Arrange: Létrehozunk egy új ProductsToOrder objektumot
            ProductsToOrder productToOrder = new ProductsToOrder();
            string expectedPhrase = "Teszt keresési kifejezés";

            // Act: Beállítjuk a Phrase értékét
            productToOrder.Phrase = expectedPhrase;
            string actualPhrase = productToOrder.Phrase;

            // Assert: Ellenőrizzük, hogy a beállított érték megegyezik a visszakapott értékkel
            Assert.That(actualPhrase, Is.EqualTo(expectedPhrase), "A Phrase property értéke nem egyezik a beállított értékkel!");
        }

        [Test]
        public void ProductsToOrder_Id_Property_Alapértelmezett_Érték()
        {
            // Arrange & Act: Új objektum létrehozása
            ProductsToOrder productToOrder = new ProductsToOrder();

            // Assert: Ellenőrizzük, hogy az id alapértéke 0
            // Mivel ez egy Identity mező az adatbázisban, ezért alapértelmezetten 0 értéke van
            // Adatbázisba mentéskor fog kapni valódi értéket
            Assert.That(productToOrder.id, Is.EqualTo(0), "Az ID alapértelmezett értéke nem 0!");
        }
    }
} 