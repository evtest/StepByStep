using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace ClassLibrary
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AssertClass()
        {
            Assert.IsTrue(true);
            Thread.Sleep(5000);
        }
    }
}
