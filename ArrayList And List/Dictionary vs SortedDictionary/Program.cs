using System;
using System.Collections.Generic;
namespace Dictionary_vs_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> people = new() // not sorted by  key, use hash-codes of keys
            {
            [111] = "Olena",
            [55] = "Ivan",
            [77] = "Olia"
            };
            people.Add(100, "Dmytro");
            // Equals 1/2 = 5/ 10 GetHashCode
            foreach (var p in people)
            {
                Console.WriteLine($"Id : {p.Key, 10} {p.Value, 10}");
            }

            SortedDictionary<int, string> peopleS = new SortedDictionary<int, string>(people);
            peopleS.Add(22, "Oleg");
            peopleS.Add(33, "Marina");
            Console.WriteLine("Sorted people");
            foreach (var p in peopleS)
            {
                Console.WriteLine($"Id : {p.Key,10} {p.Value,10}");
            }
        }
    }
}
