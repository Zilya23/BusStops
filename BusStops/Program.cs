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
        static public HashSet<string> Bus = new HashSet<string>();
        static public List<string> Stop_List;
        static public void Main(string[] args)
        {
            Buses = new Dictionary<string, HashSet<string>>();
            Stops = new Dictionary<string, HashSet<string>>();

            Stop_List = new List<string>() { "Остановка1", "Остановка2", "Остановка3", "Остановка4" };
   
            NEW_BUS(5, "34", Stop);
            Print_Bus(Buses, "34");
            BUSES_FOR_STOP(Stops, "Остановка1");

            Stop_List = new List<string>() {"Остановка2", "Остановка3", "Остановка4", "Остановка5" };

            NEW_BUS(5, "45", Stop);
            Print_Bus(Buses, "45");

            //ALL_BUSES(Buses);

            BUSES_FOR_STOP(Stops, "Остановка1");

            STOPS_FOR_BUS("34", Buses, Stops);

        }


        public static void NEW_BUS(int count, string busName, HashSet<string> Stop)
        {
            Stop.Clear();
            NEW_HASH(Stop_List, busName);
            Buses.TryAdd(busName, Stop);
        }
        public static void NEW_HASH(List<string> Stop_List, string bus_name)
        {
            Stop_List.ForEach(delegate (string name)
            {
                Bus.Add(bus_name);
                Stops.TryAdd(name, Bus);
                Stop.Add(name);
            });
        }
        public static void BUSES_FOR_STOP(Dictionary<string, HashSet<string>> Stopp, string _stop)
        {
            foreach (var i in Stopp)
            {
                if (i.Key == _stop)
                {
                    Console.WriteLine($"Название остановки: {i.Key}");
                    Console.WriteLine("Автобусы: ");
                    foreach (var a in i.Value)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void STOPS_FOR_BUS(string bus, Dictionary<string, HashSet<string>> Buss, Dictionary<string, HashSet<string>> Stopp)
        {
            foreach (var _bus in Buss)
            {
                if(_bus.Key == bus)
                {
                    Console.WriteLine($"Номер автобуса: {_bus.Key}");
                    Console.WriteLine("Остановки: ");
                    foreach (var a in _bus.Value)
                    {
                        Console.WriteLine(a);
                        foreach (var _stop in Stopp)
                        {
                            if (_stop.Key == a)
                            {
                                Console.WriteLine("Автобусы на которые можно пересесть: ");
                                foreach (var d in _stop.Value)
                                {
                                    Console.WriteLine(d);
                                }
                            }
                        }

                    }
                }
            }
        }
        public static void ALL_BUSES(Dictionary<string, HashSet<string>> Buss)
        {
            foreach (var i in Buss)
            {
                Console.WriteLine($"Номер автобуса: {i.Key}");
                Console.WriteLine("Остановки: ");
                foreach (var a in i.Value)
                {
                    Console.WriteLine(a);
                }
            }
        }
        public static void Print_Bus(Dictionary<string, HashSet<string>> Buss, string key)
        {
            foreach (var i in Buss)
            {
                if (i.Key == key)
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
}
