using System;

namespace Struct
{
    struct Person
    {
        private string name;
        int age;
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set
            {
                if (age >= 0 && age <= 120)
                {
                    age = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name : {name}, Age : {age}";
        }
    }
    class Program
    {
        static void EnterPerson(ref Person person)
        {
            Console.WriteLine($"Enter age : ");
            person.Age = int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            Person person = new Person("Ann", 22);
            Person clone = person;
            clone.Age = 18;
            Console.WriteLine(person);
            Console.WriteLine(clone);
            EnterPerson(ref person);
            Console.WriteLine(person);
        }
    }
}
