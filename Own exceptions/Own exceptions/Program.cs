using System;

namespace Own_exceptions
{
    class Program
    {
        static void Main()
        {
            try 
            {
                Console.WriteLine("Enter a number : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Succsessful reading : {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception type {ex.GetType().Name}, Message :  {ex.Message}");
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.Data}");
                Console.WriteLine($"{ex.InnerException}");
                Console.WriteLine($"{ex.HelpLink}");
                Console.WriteLine($"{ex.HResult}");
                Console.WriteLine($"{ex.Source}");
                Console.WriteLine($"{ex.StackTrace}");
                Console.WriteLine($"{ex.TargetSite.Name}");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception type {ex.GetType().Name}, Message :  {ex.Message}");
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
