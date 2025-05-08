using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPModul12_2311104060;


namespace TPModul12_2311104060_
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestCariTandaBilangan_Negatif()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Negatif", form.CariTandaBilangan(-10));
        }

        [TestMethod]
        public void TestCariTandaBilangan_Positif()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Positif", form.CariTandaBilangan(5));
        }

        [TestMethod]
        public void TestCariTandaBilangan_Nol()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Nol", form.CariTandaBilangan(0));
        }
    }

}
