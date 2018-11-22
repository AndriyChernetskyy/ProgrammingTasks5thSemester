using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.Models;

namespace TestingTask3
{
    [TestClass]
    public class TestOfVehicle
    {
        [TestMethod]
        public void VehicleWightTest()
        {
               Vehicle a=new Vehicle(VehicleType.Box,50);
               Assert.AreEqual(a.Weight,50);
        }
        [TestMethod]
        public void VehicleTypeTest()
        {
            Vehicle a = new Vehicle(VehicleType.Dropside, 50);
            Assert.AreEqual(VehicleType.Dropside,a.Type);
        }
    }
}
