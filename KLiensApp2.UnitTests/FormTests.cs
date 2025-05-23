using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace KLiensApp2.UnitTests
{
    [TestFixture]
    public class FormTests
    {
        // Ez a teszt csak azt ellenőrzi, hogy a Form2 létrehozható-e
        // Alap teszt, amit minden kezdő fejlesztő tud
        [Test]
        public void Form2_Létrehozás()
        {
            try
            {
                // Act: Létrehozunk egy új Form2 objektumot
                // Mivel UI elem, ezért try-catch blokkba tesszük
                using (Form2 form = new Form2())
                {
                    // Assert: Ha idáig eljutunk, akkor sikeres a teszt
                    Assert.Pass("A Form2 objektum sikeresen létrejött!");
                }
            }
            catch (Exception ex)
            {
                // Ha kivétel keletkezik, akkor a teszt elbukott
                Assert.Fail($"A Form2 létrehozásakor kivétel keletkezett: {ex.Message}");
            }
        }
    }
} 
