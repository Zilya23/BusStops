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
        static public HashSet<string> Stop;
        static void Main(string[] args)
        {
            Buses = new Dictionary<string, HashSet<string>>();
            Stops = new Dictionary<string, HashSet<string>>();

            //Dictionary<string, HashSet<string>> Buses = new Dictionary<string, HashSet<string>>();
            //Dictionary<string, HashSet<string>> Stops = new Dictionary<string, HashSet<string>>();

            List<string> Stop_List = new List<string>() { "Остановка1", "Остановка2", "Остановка3", "Остановка4" };

            NEW_HASH(Stop_List);
            NEW_BUS(5, "34", Stop);
            Print_Bus(Buses);
        }


        public static void NEW_BUS(int count, string busName, HashSet<string>Stop)
        {
            Buses.TryAdd(busName, Stop);
        }

        public static void NEW_HASH(List<string> Stop_List)
        {
            Stop_List.ForEach(delegate (string name)
            {
                Stop.Add(name);
            });
        }

        public static void Print_Bus(Dictionary<string, HashSet<string>> Bus)
        {

            foreach (var i in Bus)
            {
                Console.WriteLine($"key: {i.Key}  value: {i.Value}");
            }
        }
    }
}
