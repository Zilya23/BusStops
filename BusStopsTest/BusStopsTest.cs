using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using BusStops;

namespace BusStopsTest
{
    [TestClass]
    public class BusStopsTest
    {
        [TestMethod]
        public void TestAddingBus()
        {
            Bus bus = new Bus();
            
            Assert.AreEqual(bus.BUS_COUNT("Остановка1"), 0);
            Assert.AreEqual(bus.BUS_COUNT("Остановка1"), 0);
            Assert.AreEqual(bus.STOP_COUNT("34"), 0);
            Assert.AreEqual(bus.STOP_COUNT("34a"), 0);

            string stoplist = "stop1 stop2 stop3";
            bus.NEW_BUS("34", 3, stoplist.Split());
        }
    }
}