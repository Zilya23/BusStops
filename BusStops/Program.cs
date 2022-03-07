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
        static public HashSet<string> Stop = new HashSet<string>();
        static void Main(string[] args)
        {
            Buses = new Dictionary<string, HashSet<string>>();
            Stops = new Dictionary<string, HashSet<string>>();

            List<string> Stop_List = new List<string>() { "Остановка1", "Остановка2", "Остановка3", "Остановка4" };

            NEW_HASH(Stop_List);
            NEW_BUS(5, "34", Stop);
            Print_Bus(Buses, "34");

            NEW_HASH(Stop_List);
            NEW_BUS(5, "45", Stop);
            Print_Bus(Buses, "45");

            Print_Buses(Buses);
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

        public static void Print_Bus(Dictionary<string, HashSet<string>> Bus, string key)
        {

            foreach (var i in Bus)
            {
                if(i.Key == key)
                {
                    Console.WriteLine($"Номер автобуса: {i.Key}");
                    Console.WriteLine("Остановки: ");
                    foreach (var a in i.Value)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }

        public static void Print_Buses(Dictionary<string, HashSet<string>> Bus)
        {
            foreach (var i in Bus)
            {
                Console.WriteLine($"Номер автобуса: {i.Key}");
                Console.WriteLine("Остановки: ");
                foreach (var a in i.Value)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
