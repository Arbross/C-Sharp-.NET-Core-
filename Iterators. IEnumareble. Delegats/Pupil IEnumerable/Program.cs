using System;

namespace Pupil_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil ann = new Pupil { Name = "Ann" };
            ann.Marks.Add(12);
            ann.Marks.Add(10);
            ann.Marks.Add(11);

            Console.WriteLine("Marks : ");
            foreach (int m in ann)
            {
                Console.WriteLine($"{m, 5}");
            }
            Console.WriteLine("Good Marks : ");
            foreach (int m in ann.GetMarksHigher(10))
            {
                Console.WriteLine($"{m,5}");
            }
        }
    }
}
