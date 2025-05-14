using System;
using Jurnal12_2311104060;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_2311104060
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();
            
        [TestMethod]
        public void TestPangkatValid()
        {
            int hasil = form.CariNilaiPangkat(2, 3); 
            Assert.AreEqual(8, hasil);
        }

        [TestMethod]
        public void TestPangkatNegatif()
        {
            int hasil = form.CariNilaiPangkat(-2, 3); 
            Assert.AreEqual(-8, hasil);
        }

        [TestMethod]
        public void TestPangkatDenganNol()
        {
            int hasil = form.CariNilaiPangkat(5, 0); 
            Assert.AreEqual(1, hasil);
        }

        [TestMethod]
        public void TestPangkatMelebihiMaxInt()
        {
            int hasil = form.CariNilaiPangkat(1000000, 10); 
            Assert.AreEqual(-3, hasil); 
        }

        [TestMethod]
        public void TestPangkatNegatifExponent()
        {
            int hasil = form.CariNilaiPangkat(2, -1); 
            Assert.AreEqual(-2, hasil); 
        }
    }
}
