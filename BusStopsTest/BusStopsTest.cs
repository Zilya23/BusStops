using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace BusStopsTest
{
    [TestClass]
    public class BusStopsTest
    {
        [TestMethod]
        public void TestAddingBus()
        {
            BusStops.Program.Buses = new Dictionary<string, HashSet<string>>();
            BusStops.Program.Buses.TryAdd("34");
        }
    }
}