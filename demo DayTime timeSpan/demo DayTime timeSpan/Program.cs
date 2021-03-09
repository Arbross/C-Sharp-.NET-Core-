using System;

namespace demo_DayTime_timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine($"{dateTime:dd-MMMM-yyy}");

            Console.WriteLine(dateTime.AddDays(2));
            DateTime birth = new DateTime(2000, 3, 7);
            TimeSpan time = dateTime - birth;
            int age = (int)(time.TotalDays / 365.2);
            Console.WriteLine($"Age : {age}");
        }
    }
}
