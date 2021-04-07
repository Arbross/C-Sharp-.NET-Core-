using System;
using System.IO;

namespace StreamReader_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "info.txt";
            using (StreamReader sw = new StreamReader(fname))
            {
                // sw.WriteLine("One line");
                // sw.WriteLine($"Today : {DateTime.Now}");
            }
            using (StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine("Line by line");
            using (StreamReader sr = new StreamReader(fname))
            {
                string line = sr.ReadLine();
                int i = 0;
                while (line != null)
                {
                    Console.WriteLine($"#{i, -4} : {line}");
                    line = sr.ReadLine();
                }
            }
            Console.WriteLine("Char by char");
            using (StreamReader sr = new StreamReader(fname))
            {
                int symbol = sr.Read();
                while (symbol != -1)
                {
                    Console.WriteLine($"{(char)symbol}");
                    symbol = sr.Read();
                }
            }
        }
    }
}
