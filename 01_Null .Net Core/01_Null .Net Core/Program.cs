using System;
using System.Collections.Generic;

namespace _01_Null_.Net_Core
{
    class Person
    {
        public Person(string name = "Noname")
        {

        }
        private string name;

        public string Name
        {
            get => name;
            set => name = value ?? "Noname";
        }

    }
    class Worker : Person
    {

    }
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            people.Add(new Worker());
            // people.AddRange(new Worker());
            // people.RemoveAll();

            string str = null; // "Demo text";
            // str.Remove(0, 4);
            Console.WriteLine($"Try remove : {str?.Remove(0, 4)?? "Bad value"}");

            int[] arr = { 10, 12, 100, 345 }; // null
            Console.WriteLine($"Length : {arr?.Length ?? 0}");
            Console.WriteLine($"arr[0] = {arr?[0]}");

            // ?? null-COLEASING
            Console.WriteLine(str ?? "Empty string"); // str != nullptr ? str : "Empty str"
            // ?. NULL-CONDITIONAL
            // ?[]

            Person person = new Person(null);
            Console.WriteLine(person.Name);

            arr ??= new int[10];
            Console.WriteLine($"Length : {arr?.Length ?? 0}");









            // int value = null;
        }
    }
}
