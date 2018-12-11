using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Task3.Models;

namespace TestingTask3
{
    [TestClass]
    public class TestOfCarrier
    {
        [TestMethod]
        public void TestCarrierName()
        {
            Carrier tmp = new Carrier("Oleh", "+380949418149", "oleh@gmail.com", new Vehicle(VehicleType.Box,20));
            Assert.AreEqual("Oleh",tmp.Name);
        }
        [TestMethod]
        public void TestCarrierEmail()
        {
            Carrier tmp = new Carrier("Oleh", "+380949418149", "oleh@gmail.com", new Vehicle(VehicleType.Box, 50));
            Assert.AreEqual("oleh@gmail.com", tmp.Email);
        }
        [TestMethod]
        public void TestCarrierPhone()
        {
            Carrier tmp = new Carrier("Oleh", "+380949418149", "oleh@gmail.com", new Vehicle(VehicleType.Box, 50));
            Assert.AreEqual("+380949418149", tmp.PhoneNumber);
        }
    }
}
