using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DummyTest
    {
        [TestMethod]
        public void BasicSums()
        {
            int x = 2 + 2;

            Assert.AreEqual(x, 2 + 2);
        }

        [TestMethod]
        public void AdvancedMath()
        {
            int x = 2 - 2;

            Assert.AreEqual(x, 1);
        }

        [TestMethod]
        public void NotMathAtAll()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
