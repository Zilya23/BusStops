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
            
            Assert.AreEqual(bus.BUS_COUNT("���������1"), 0);
            Assert.AreEqual(bus.BUS_COUNT("���������1"), 0);
            Assert.AreEqual(bus.STOP_COUNT("34"), 0);
            Assert.AreEqual(bus.STOP_COUNT("34a"), 0);

            
        }
        [TestMethod]
        public void TestCreateBus()
        {
            Bus bus = new Bus();

            bus.Stop_List = new List<string>() { "���������1", "���������2", "���������3", "���������4" };
            bus.NEW_BUS(3, "34");

            Assert.IsNotNull(bus.Buses["34"]);
        }
        [TestMethod]
        public void BusesInStopCount()
        {
            Bus bus = new Bus();

            bus.Stop_List = new List<string>() { "���������1", "���������2", "���������3", "���������4" };
            bus.NEW_BUS(4, "34");

            bus.Stop_List = new List<string>() { "���������2", "���������4", "���������5"};
            bus.NEW_BUS(3, "35");

            Assert.AreEqual(bus.BUSES_FOR_STOP(bus.Stops, "���������2"), 2);
        }

        [TestMethod]
        public void AllBusesCount()
        {
            Bus bus = new Bus();

            bus.Stop_List = new List<string>() { "���������1", "���������2", "���������3", "���������4" };
            bus.NEW_BUS(4, "34");

            bus.Stop_List = new List<string>() { "���������2", "���������4", "���������5" };
            bus.NEW_BUS(3, "35");

            bus.Stop_List = new List<string>() { "���������2", "���������4", "���������6" };
            bus.NEW_BUS(3, "33");

            bus.Stop_List = new List<string>() { "���������2", "���������4", "���������7" };
            bus.NEW_BUS(3, "39");

            Assert.AreEqual(bus.ALL_BUSES(bus.Buses), 4);
        }
        //[TestMethod]
        //public void StopForBusCount()
        //{

        //}
    }
}