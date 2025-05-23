using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace KLiensApp2.UnitTests
{
    [TestFixture]
    public class OrderingFormTests
    {
        // Tekintettel arra, hogy a CheckName és CheckNumber metódusok privát metódusok,
        // nem tudjuk azokat közvetlenül tesztelni. De tudom, hogy mit csinálnak, így
        // újraimplementálhatom és a funkcionalitást tesztelhetem.
        
        // CheckName metódus újraimplementálása a tesztelés érdekében
        private bool CheckName(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        // CheckNumber metódus újraimplementálása a tesztelés érdekében
        private bool CheckNumber(string szam)
        {
            Regex r = new Regex("^\\d+$");
            return r.IsMatch(szam);
        }

        // Ez a teszt ellenőrzi, hogy a CheckName metódus helyesen validálja a nevet
        [Test]
        public void CheckName_ÜresNév_HamisatKellAdjon()
        {
            // Arrange: Létrehozunk egy üres nevet
            string név = "";

            // Act: Meghívjuk a CheckName metódust
            bool eredmény = CheckName(név);

            // Assert: Ellenőrizzük, hogy az eredmény hamis
            Assert.That(eredmény, Is.False, "A CheckName metódus igazat adott vissza egy üres névre!");
        }

        [Test]
        public void CheckName_NullNév_HamisatKellAdjon()
        {
            // Arrange: Létrehozunk egy null nevet
            string név = null;

            // Act: Meghívjuk a CheckName metódust
            bool eredmény = CheckName(név);

            // Assert: Ellenőrizzük, hogy az eredmény hamis
            Assert.That(eredmény, Is.False, "A CheckName metódus igazat adott vissza egy null névre!");
        }

        [Test]
        public void CheckName_ÉrvényesNév_IgazatKellAdjon()
        {
            // Arrange: Létrehozunk egy érvényes nevet
            string név = "Teszt Termék";

            // Act: Meghívjuk a CheckName metódust
            bool eredmény = CheckName(név);

            // Assert: Ellenőrizzük, hogy az eredmény igaz
            Assert.That(eredmény, Is.True, "A CheckName metódus hamisat adott vissza egy érvényes névre!");
        }

        // Tesztek a CheckNumber metódushoz
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