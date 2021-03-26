using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    class Program
    {
        static void Main()
        {
            Drink f1 = new Drink();
            Console.WriteLine(f1);

            List<Drink> dr = new List<Drink>
            {
                f1,
                new Drink()
            };
            dr.Sort();
            Console.WriteLine("------------------------------------------");
            foreach (Drink p in dr)
            {
                Console.WriteLine(p);
            }
            dr.Sort(new CompareByDeveloper());
        }
    }
}
