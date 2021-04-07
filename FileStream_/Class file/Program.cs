using System;
using System.Collections.Generic;
using System.IO;

namespace Class_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "file.txt";
            File.WriteAllText(fname, "Hello world\nSecond line\n");
            File.AppendAllText(fname, "Third line\n");
            List<string> lines = new() { "one", "two" };
            File.AppendAllLines(fname, lines);

            Console.WriteLine($"Content of file : {File.ReadAllText(fname)}");
            Console.WriteLine($"{File.ReadAllLines(fname)}");
            File.ReadAllLines(fname);
            if (File.Exists(fname))
            {
                Console.WriteLine($"Creation date : {File.GetCreationTime(fname)}");
                Console.WriteLine($"Access time(last) : {File.GetLastAccessTime(fname)}");
                File.SetAttributes(fname, FileAttributes.ReadOnly | FileAttributes.Normal);
                Console.WriteLine($"Attributes : {File.GetAttributes(fname)}");
            }
        }
    }
}
