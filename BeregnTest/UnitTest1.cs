using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaksBeregner;

namespace BeregnTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInnledendeSerie()
        {
            Beregner b = new Beregner(6);

            Assert.AreEqual("6/1", b.BeregnMin(8, 8, 3));
            Assert.AreEqual("1/0", b.BeregnMin(8, 3, 0));
            Assert.AreEqual("2/0", b.BeregnMin(12, 8, 4));
            Assert.AreEqual("3/2", b.BeregnMin(9, 6, 5));

            Assert.AreEqual("6/3", b.BeregnMaks(8, 8, 3));
            Assert.AreEqual("3/0", b.BeregnMaks(8, 3, 0));
            Assert.AreEqual("6/4", b.BeregnMaks(12, 8, 4));
            Assert.AreEqual("6/5", b.BeregnMaks(9, 6, 5));
        }

        [TestMethod]
        public void TestFinale()
        {
            Beregner b = new Beregner(12);

            Assert.AreEqual("3/0", b.BeregnMin(14, 5, 2));
            Assert.AreEqual("8/8", b.BeregnMin(14, 10, 10));
            Assert.AreEqual("0/0", b.BeregnMin(21, 7, 3));
            Assert.AreEqual("10/8", b.BeregnMin(16, 14, 12));

            Assert.AreEqual("5/2", b.BeregnMaks(14, 5, 2));
            Assert.AreEqual("10/10", b.BeregnMaks(14, 10, 10));
            Assert.AreEqual("7/3", b.BeregnMaks(21, 7, 3));
            Assert.AreEqual("12/12", b.BeregnMaks(16, 14, 12));
        }
    }
}
