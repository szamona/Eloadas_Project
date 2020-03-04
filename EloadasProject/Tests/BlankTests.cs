using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace EloadasProject.Tests
{
    [TestFixture]
    class BlankTests
    {
        [TestCase]
        public void HibasKezdoertek()
        {
            Assert.Throws<ArgumentException>(() => {
                var teszt = new Eloadas(0, 0);
            });
        }

        [TestCase]
        public void UjEloadasSzabadhelyeinekEllenorzese()
        {
            var teszt = new Eloadas(8, 8);
            Assert.AreEqual(64, teszt.SzabadHelyek, "Hiba! Nem megfelelő a férőhelyek száma.");
        }

        [TestCase]
        public void SzabadHelyek()
        {
            var teszt = new Eloadas(8, 8);
            teszt.Lefoglal();
            Assert.AreEqual(63, teszt.SzabadHelyek, "Hiba! Nem megfelelő a férőhelyek száma.");
        }
    

        [TestCase]
        public void TeliEloadasEllenorzes()
        {
            var teszt = new Eloadas(1, 1);
            teszt.Lefoglal();
            Assert.AreEqual(true, teszt.Teli(), "Hibás Teli() függvény érték.");
        }

        [TestCase]
        public void TeliEloadasEllenorzes2()
        {
            var teszt = new Eloadas(1, 1);
            teszt.Lefoglal();
            Assert.AreEqual(false, teszt.Teli(), "Hibás Teli() függvény érték. .");
        }


        [TestCase]
        public void HibasFoglaltTeszt()
        {
            var teszt = new Eloadas(2, 2);
            teszt.Lefoglal();
            Assert.Throws<ArgumentException>(() => {
                teszt.Foglalt(0, 0);
            });
        }

        [TestCase]
        public void SzabadHelyekNegativVizsgalat()
        {
            var teszt = new Eloadas(8, 8);
            Assert.Greater(teszt.SzabadHelyek, -1, "Hiba! Nem megfelelő a férőhelyek száma.");
        }

        [TestCase]
        public void LefoglalNull()
        {
            var teszt = new Eloadas(8, 8);
            Assert.AreNotEqual(null, teszt.Lefoglal(), "Hiba! logikai változó null értéket kapott.");
        }

        [TestCase]
        public void FoglaltVizsgalat()
        {
            var teszt = new Eloadas(8, 8);
            teszt.Lefoglal();
            Assert.AreEqual(true, teszt.Foglalt(1, 1), "A lefoglalt hely nem foglalt.");
        }

        [TestCase]
        public void FoglaltTesztNull()
        {
            var teszt = new Eloadas(8, 8);
            teszt.Lefoglal();
            Assert.AreNotEqual(null, teszt.Foglalt(1, 1), "Hiba! logikai változó null értéket kapott.");
        }

        [TestCase]
        public void FoglaltTesztOutOfRange()
        {
            var teszt = new Eloadas(1, 1);
            Assert.Throws<IndexOutOfRangeException>(() => {
                teszt.Foglalt(3, 3);
            });
        }

       
    }
}

