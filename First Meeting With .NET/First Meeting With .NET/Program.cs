using System;

// OOP
namespace First_Meeting_With_.NET
{
    class Calculator
    {
        static decimal plus(decimal a, decimal b)
        {
            return a + b;
        }

        static decimal mult(decimal a, decimal b)
        {
            return a * b;
        }

        static void calc()
        {
            decimal one = 0, two = 0;
            char operation;
            do
            {
                Console.WriteLine("[i]. Input numbers");
                Console.WriteLine("[+]. Plus numbers");
                Console.Write("[*]. Mult numbers\n");
                Console.Write("[q]. Exit\n");
                operation = char.Parse(Console.ReadLine());
                // Random rand = new Random();

                switch (operation)
                {
                    case 'I':
                    case 'i':
                    {
                        try {
                            Console.WriteLine("Input : ");
                            one = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Input : ");
                            two = decimal.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error {ex.Message}");
                        }
                    }
                    break; // goto mitka return 

                    case '+':
                    {
                        Console.WriteLine($"{one} + {two} = {plus(one, two)}"); // інтерполяційний рядок
                    }
                    break; // goto mitka return 

                    case '*':
                    {
                        Console.WriteLine("{1} * {2} = {2}", one, two, mult(one, two)); // інтерполяційний рядок
                    }
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (char.ToLower(operation) != 'q');
        }

        static int Main()
        {
            calc();    
            return 0;
        }
    }
}
