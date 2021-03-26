using System;
using System.Collections.Generic;

namespace IClonable_demo
{
    class Program
    {
        static void Main()
        {
            Pupil ivan = new Pupil("Ivan", 4, 10, 5);
            Console.WriteLine(ivan);

            Pupil clone = (Pupil)ivan.Clone();
            clone.changeMark(0, 12);
            Console.WriteLine(clone);
            Console.WriteLine(ivan);

            List<Pupil> pupil = new List<Pupil>
            {
                ivan,
                new Pupil("Anton", 17)
            };
            pupil.Sort();
            Console.WriteLine("------------------------------------------");
            foreach (Pupil p in pupil)
            {
                Console.WriteLine(p);
            }
            // pupil.Sort(new CmpAvgScorePupil());
        }
    }
}
