﻿using System;
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
        public void AssertClassStart()
        {
            Assert.IsTrue(true);
            Thread.Sleep(5000);
        }

        [Test]
        public void AssertClassFail()
        {
            Assert.IsFalse(false);
            Thread.Sleep(1000);
        }

        [Test]
        public void AssertClassFails()
        {
            Assert.IsFalse(false);
            Thread.Sleep(1000);
        }
    }
}
