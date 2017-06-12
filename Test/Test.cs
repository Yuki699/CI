using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Simple()
        {
            Console.WriteLine("test 1");
        }

        [Test]
        public void Add()
        {
            int result = Program.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
