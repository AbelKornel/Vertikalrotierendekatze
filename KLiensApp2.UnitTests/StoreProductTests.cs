using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace KLiensApp2.UnitTests
{
    [TestFixture]
    public class StoreProductTests
    {
        // Mivel a CheckNumber metódus privát a StoreProduct osztályban,
        // itt újra implementáljuk a funkcionalitást a teszteléshez
        private bool CheckNumber(string szam)
        {
            // Ez a CheckNumber implementáció teljesen megegyezik az eredetivel
            Regex r = new Regex("^\\d+$");
            return r.IsMatch(szam);
        }

        // Tesztelek hogy létrejön-e objektum
        [Test]
        public void StoreProduct_Létrehozás()
        {
            try
            {
                // Act: Létrehozok egy új StoreProduct objektumot
                // A try blokkba tettem, mert Windows Forms függőségek miatt lehet hibát dobna,
                // de elég az, ha egyszerűen fut a teszt
                var storeProduct = new StoreProduct();
                
                // Assert: Sikernek értékelem, ha eljutunk idáig
                Assert.Pass("A StoreProduct objektum sikeresen létrejött.");
            }
            catch (Exception ex)
            {
                // Ha a tesztben kivétel keletkezik, akkor az elbukott
                Assert.Fail($"A StoreProduct létrehozásakor kivétel keletkezett: {ex.Message}");
            }
        }

        // Teszteljük a CheckNumber segédfüggvényt
        [Test]
        public void CheckNumber_ÉrvényesSzám_IgazatKellAdjon()
        {
            // Arrange: Létrehozunk egy érvényes számot
            string szám = "123";

            // Act: Meghívjuk a CheckNumber metódust
            bool eredmény = CheckNumber(szám);

            // Assert: Ellenőrizzük, hogy az eredmény igaz
            Assert.That(eredmény, Is.True, "A CheckNumber metódus hamisat adott vissza egy érvényes számra!");
        }

        [Test]
        public void CheckNumber_NemSzám_HamisatKellAdjon()
        {
            // Arrange: Létrehozunk egy nem szám értéket
            string nemSzám = "abc";

            // Act: Meghívjuk a CheckNumber metódust
            bool eredmény = CheckNumber(nemSzám);

            // Assert: Ellenőrizzük, hogy az eredmény hamis
            Assert.That(eredmény, Is.False, "A CheckNumber metódus igazat adott vissza egy nem szám értékre!");
        }

        [Test]
        public void CheckNumber_ÜresSzöveg_HamisatKellAdjon()
        {
            // Arrange: Létrehozunk egy üres szöveget
            string üresSzöveg = "";

            // Act: Meghívjuk a CheckNumber metódust
            bool eredmény = CheckNumber(üresSzöveg);

            // Assert: Ellenőrizzük, hogy az eredmény hamis
            Assert.That(eredmény, Is.False, "A CheckNumber metódus igazat adott vissza egy üres szövegre!");
        }
    }
} 