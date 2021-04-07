using System;
using System.Collections.Generic;

namespace Generic_Methods
{
    class Person//  : IComparable
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public Person() : this ("Noname")
        {
            
        }
        public override string ToString()
        {
            return $"Person : {Name}";
        }
        public virtual void Busy()
        {
            Console.WriteLine($"{Name} is busy");
        }
    }
    class Worker : Person
    {
        public string Position { get; set; }
        public Worker(string name = "Noname", string position = "Noposition")
            : base(name)
        {
            Position = position;
        }
        public override void Busy()
        {
            Console.WriteLine($"Worker {Name} is working in position {Position}");
        }
        public override string ToString()
        {
            return $"Worker : {Name}\t Positon : {Position}";
        }
    }
    class People<T> where T : Person, new()
    {
        public List<T> people = new List<T>();
        public void BusyAll()
        {
            foreach (var item in people)
            {
                item.Busy();
            }
        }
    }

    class Program
    {
        static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        static bool IsExistInEnum<T> (T value) where T : Enum
        {
            return Enum.IsDefined(typeof(T), value);
        }
        static void Main()
        {
            //int value = 10;
            //Console.WriteLine($"Is exists {value} : {IsExistInEnum<ConsoleColor>((ConsoleColor)value)}");
            //int one = 10, two = 34;
            //Console.WriteLine($"Max : {Max(one, two)}");

            //string oneStr = "one", twoStr = "two";
            //Console.WriteLine($"Max : {Max(oneStr, twoStr)}");

            var P = new Person("Olena");
            Console.WriteLine(P);
            Worker w = new Worker("Petro", "Developer");
            Console.WriteLine(w);

            People<Person> people = new People<Person>();
            people.people.Add(P);
            people.people.Add(w);
            people.BusyAll();
            // Person person = new(); 
        }
    }
}
