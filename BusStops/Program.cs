using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace BusStops
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Bus bus = new Bus();

            bus.Stop_List = new List<string>() { "Остановка1", "Остановка2", "Остановка3", "Остановка4" };

            bus.NEW_BUS(5, "34");
            //Print_Bus(Buses, "34");
            bus.BUSES_FOR_STOP(bus.Stops, "Остановка1");

            bus.Stop_List = new List<string>() { "Остановка2", "Остановка3", "Остановка4", "Остановка5" };

            bus.NEW_BUS(5, "45");
            //Print_Bus(Buses, "45");

            bus.ALL_BUSES(bus.Buses);

            bus.BUSES_FOR_STOP(bus.Stops, "Остановка1");

            bus.STOPS_FOR_BUS("34", bus.Buses, bus.Stops);

        }

    }
}
