using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_calc_2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.Calculate(10, 20, "+"), 30);
            Assert.AreEqual(Program.Calculate(10, 0, "div"), 42);
        }
    }
}
