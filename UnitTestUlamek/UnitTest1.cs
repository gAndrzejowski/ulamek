using System;
using UlamekLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUlamek
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KonstruktorDomyslnyLicznik0Mianownik1()
        {
            var u = new Ulamek();

            Assert.AreEqual(u.Licznik, 0);
            Assert.AreEqual(u.Mianownik, 1);
        }

        [DataTestMethod]
        [DataRow(0,1,0,1)]
        [DataRow(0,5,0,1)]
        [DataRow(4,7,4,7)]
        public void KonstruktorDwuargumentowy_OK(long l, long m, long ul, long um)
        {
            var u = new Ulamek(l, m);

            Assert.AreEqual(u.Licznik, ul);
            Assert.AreEqual(u.Mianownik, um);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void KonstruktorMianownik0_Blad()
        {
            var u = new Ulamek(4, 0);
            
        }

        [DataTestMethod]
        [DataRow(1,2,1,2)]
        [DataRow(-1,2,-1,2)]
        [DataRow(1,-2,-1,2)]
        [DataRow(-1,-2,1,2)]
        public void Konstruktor_ZnakUlamkaWLicznikuMianownikDodatni(long l, long m, long ul, long um)
        {
            var u = new Ulamek(l, m);

            Assert.IsTrue(u.Mianownik > 0);
            Assert.IsTrue(Math.Sign(l * m) == Math.Sign(u.Licznik * u.Mianownik));

            Assert.AreEqual(u.Licznik, ul);
            Assert.AreEqual(u.Mianownik, um);
        }

        [DataTestMethod]
        [DataRow(2,4,1,2)]
        [DataRow(-12,-8,3,2)]
        public void KonstruktorSkracaUlamekDoLiczbWzgledniePierwszych(long l, long m, long ul, long um)
        {
            var u = new Ulamek(l, m);

            Assert.AreEqual(u.Licznik, ul);
            Assert.AreEqual(u.Mianownik, um);
            Assert.IsTrue(l * u.Mianownik == m * u.Licznik);
        }

    }
}
