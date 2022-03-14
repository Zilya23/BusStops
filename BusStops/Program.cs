using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace BusStops
{
    public class Program
    {
        static public Dictionary<string, HashSet<string>> Buses;
        static public Dictionary<string, HashSet<string>> Stops;
        static public List<string> Stop_List;
        static public void Main(string[] args)
        {
            Bus bus = new Bus();
            Buses = new Dictionary<string, HashSet<string>>();
            Stops = new Dictionary<string, HashSet<string>>();

            Stop_List = new List<string>() { "Остановка1", "Остановка2", "Остановка3", "Остановка4" };

            bus.NEW_BUS(5, "34");
            //Print_Bus(Buses, "34");
            bus.BUSES_FOR_STOP(Stops, "Остановка1");

            Stop_List = new List<string>() { "Остановка2", "Остановка3", "Остановка4", "Остановка5" };

            bus.NEW_BUS(5, "45");
            //Print_Bus(Buses, "45");

            bus.ALL_BUSES(Buses);

            bus.BUSES_FOR_STOP(Stops, "Остановка1");

            bus.STOPS_FOR_BUS("34", Buses, Stops);

        }

    }
}
