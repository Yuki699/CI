using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Min()
        {
            var res = Program.Minus(4, 2);
            Assert.AreEqual(2, res);
        }
    }
}
