using System;

// operators(fractions)
namespace _04_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "HELLO";
            string str2 = "HELLO";

            Console.WriteLine($"Hash str1 : {str1.GetHashCode()}");
            Console.WriteLine($"Hash str2 : {str2.GetHashCode()}");

            Fraction fr1 = new Fraction(1, 2);
            Console.WriteLine(fr1);

            Fraction fr2 = new Fraction(2, 4);
            Console.WriteLine(fr2);
            Console.WriteLine(fr1.Equals(fr2)); // false! WE WANT TRUE

            Console.WriteLine($"Hash fr1 : {fr1.GetHashCode()}");
            Console.WriteLine($"Hash fr2 : {fr2.GetHashCode()}");

            // Console.WriteLine(fr1 + fr2);
            // Console.WriteLine($"{fr1 + fr2}");

            Console.WriteLine($"{fr1} == {fr2} : {fr1==fr2}");
            Console.WriteLine($"++ prefix : {++fr1}, {fr2++}");
            Console.WriteLine($"++ postfix : {fr1++}, {++fr2}");
        }
    }
}
