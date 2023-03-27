using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bilet_7_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fractional_Numbers_Test()
        {
            decimal amount = (Decimal)10.103;

            bool exp = false;
            bool result = Vasilev_IS_19_Bilet_7.Form1.AmountCheck(amount);

            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void Large_Numbers_Test()
        {
            decimal amount = (Decimal)1010000001010010;

            bool exp = false;
            bool result = Vasilev_IS_19_Bilet_7.Form1.AmountCheck(amount);

            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void Negative_Numbers_Test()
        {
            decimal amount = -4;

            bool exp = false;
            bool result = Vasilev_IS_19_Bilet_7.Form1.AmountCheck(amount);

            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void Normal_Numbers_Test()
        {
            decimal amount = 1;

            bool exp = true;
            bool result = Vasilev_IS_19_Bilet_7.Form1.AmountCheck(amount);

            Assert.AreEqual(exp, result);
        }
    }
}
