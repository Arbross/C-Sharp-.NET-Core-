using System;

namespace Arrays_.NET
{
    class Program
    {
        // ref = Для змінної, котра повинна бути(прийти) проініціалізована
        // out = Для змінної, котра повинна бути(прийти) не проініціалізована, метод зобовязується надати значення
        // generic - shablon
        static void swap<T>(ref T one, ref T two) // int = struct value type COPY VALUE
        {
            T tmp = one;
            one = two;
            two = tmp;

            // Console.WriteLine($"One : {one, -7}, two : {two, 10}");
        }

        static bool equation(double a, double b, double c, out double x1, out double x2)
        {   
            double D = Math.Pow(b, 2) - 4 * a* c;
            if (D < 0)
            {
                x1 = x2 = double.NaN;
                return false;
            }

            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

            return true;
        }

        static void Main(string[] args)
        {
            // int first = 10, second = 20;
            double first = 10, second = 20;
            swap(ref first, ref second);
            Console.WriteLine($"One : {first, -7}, two : {second, 10}");

            double a = 1, b = 20, c = 1, x1, x2;
            if (equation(a, b, c, out x1, out x2))
            {
                Console.WriteLine($"X1 = {x1, 10:F2}, X2 = {x2, -10:F3}");
            }
            else {
                throw new Exception("Bad value.");
            }
        }
    }
}
