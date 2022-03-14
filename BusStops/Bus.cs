using System;
using System.Collections.Generic;
using System.Text;

namespace BusStops
{
    using Bus_Stop =  Dictionary<string, HashSet<string>>;
    public class Bus
    {
        public Bus_Stop Buses;
        public Bus_Stop Stops;
        public List<string> Stop_List;

        public Bus()
        {
            Buses = new Bus_Stop();
            Stops = new Bus_Stop();
        }
        public void NEW_BUS(int count, string busName)
        {
            Buses.TryAdd(busName, new HashSet<string>());
            Stop_List.ForEach(delegate (string name)
            {
                Buses[busName].Add(name);
                Stops.TryAdd(name, new HashSet<string>());
                Stops[name].Add(busName);
            });
        }

        public void BUSES_FOR_STOP(Dictionary<string, HashSet<string>> Stopp, string _stop)
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
        public void STOPS_FOR_BUS(string bus, Dictionary<string, HashSet<string>> Buss, Dictionary<string, HashSet<string>> Stopp)
        {
            foreach (var _bus in Buss)
            {
                if (_bus.Key == bus)
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
        public void ALL_BUSES(Dictionary<string, HashSet<string>> Buss)
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
        public int BUS_COUNT(string stop)
        {
            return Stops.ContainsKey(stop) ? Stops[stop].Count : 0;
        }
        public int STOP_COUNT(string bus)
        {
            return Buses.ContainsKey(bus) ? Buses[bus].Count : 0;
        }
        //public static void Print_Bus(Dictionary<string, HashSet<string>> Buss, string key)
        //{
        //    foreach (var i in Buss)
        //    {
        //        if (i.Key == key)
        //        {
        //            Console.WriteLine($"Номер автобуса: {i.Key}");
        //            Console.WriteLine("Остановки: ");
        //            foreach (var a in i.Value)
        //            {
        //                Console.WriteLine(a);
        //            }
        //        }
        //    }
        //}
    }
}
    