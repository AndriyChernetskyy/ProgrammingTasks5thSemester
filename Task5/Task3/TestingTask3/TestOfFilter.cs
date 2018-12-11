using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.Models;

namespace TestingTask3
{
    [TestClass]
    public class TestOfFilter
    {
        [TestMethod]
        public void TestFilter()
        {
            bool c;
            Filter a = null;
            if (a == null)
            {
                c = true;
                Assert.IsTrue(c);
            }
           Assert.IsNull(a);
        }
    }
}
