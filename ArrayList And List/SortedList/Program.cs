using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList_
{
    class Program
    {
        static void PrintKeysValues(SortedList sl)
        {
            foreach (var item in sl.Keys)
            {
                Console.Write($"{item, 7}");
            }
            Console.WriteLine();
            foreach (var item in sl.Values)
            {
                Console.WriteLine($"{item, 7}");
            }
        }
        static void PrintSortedList(SortedList sl)
        {
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"{((DictionaryEntry)item).Key}");
                Console.WriteLine($"{item.Key, 5}, {item.Value, 10}");
            }
        }
        static void Main()
        {
            // SortedListCode();

            SortedList<string, int> cars = new SortedList<string, int>()
            {
                ["BMW"] = 2010,
                ["Audi"] = 2020,
                ["Toyota"] = 2018,
                ["Bently"] = 2021
            };
            cars.Add("Mitsubishi", 2019);
            //try
            //{
            //    cars.Add("Mitsubishi", 2019);
            //    cars["Car"] = 2021;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            
            string car = null;
            int year = 2017;
            if (!cars.TryAdd(car, year))
            {
                Console.WriteLine($"Not sucessful adding {car}, {year}");
            }
            car = "Kia";
            if (cars.TryGetValue("New", out year))
            {
                Console.WriteLine($"Get value : {year}");
            }
            else
            {
                Console.WriteLine($"Key {car} isn't exists");
            }
            if (cars.Remove(car, out year))
            {
                Console.WriteLine($"Car was removed {car} with {year}");
            }
            else
            {
                Console.WriteLine($"Car {car} not found for removing");
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"Car : {item.Key,-10} Year : {item.Value,-5}");
            }
        }

        private static void SortedListCode()
        {
            SortedList sl = new SortedList(10)
            {
                { 10, "ten" },
                { 5, "five" },
                { 1, 1.5 },
                { 65, 'A' },
                { 0, false }

                // [10] = "ten",
                // [5] = "five"
            };
            sl.Add(66, 'B');
            sl.Add(2, "two");
            sl[2] = "two"; // доступаємося до Value = "Two"
            try
            {
                sl[90] = 90; // ok
                sl.Add(0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} !!!"); // OK
            }
            //Console.WriteLine("Enter key : ");
            //int key = int.Parse(Console.ReadLine());
            //if (!sl.ContainsKey(key))
            //{
            //    Console.WriteLine("Enter value : ");
            //    string value = (Console.ReadLine());
            //    sl.Add(key, value);
            //}
            //else
            //{
            //    Console.WriteLine($"Key {key} already exists");
            //}

            PrintKeysValues(sl);

            int index = 5;
            sl.SetByIndex(index, "New value");
            if (index < sl.Count && index >= 0)
            {
                Console.WriteLine($"Key by index # {index} : {sl.GetKey(index)}");
                Console.WriteLine($"Value by index # {index} : {sl.GetByIndex(index)}");
            }
            sl.Remove(100);
            sl.Remove(2);
            PrintSortedList(sl);
            sl.TrimToSize();
        }
    }
}
