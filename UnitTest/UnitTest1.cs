using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Substract()
        {
            int result = Program.Minus(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
