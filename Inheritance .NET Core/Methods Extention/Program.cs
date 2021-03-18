using System;
using System.Linq;

namespace Methods_Extention
{
    // ectention mathods : static method in static class
    static class ExtString
    {
        public static int CountWords(this string str, string word = null)
        {
           if (word == null)
           {
                return 0;
           }
            var words = str.Split(" \t\n,-/\\.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
           return words.Count(x => x == word);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "line, Demo line line line";
            Console.WriteLine(str.CountWords("line"));
        }
    }
}
