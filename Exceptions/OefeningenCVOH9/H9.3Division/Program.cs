using System;

namespace H9._3Division
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Give a value for a: ");
                int valueA = int.Parse(Console.ReadLine());

                Console.Write("Give a value for b: ");
                int valueB = int.Parse(Console.ReadLine());
                int modulus = valueA % valueB;
                Console.WriteLine($"The modulus of a divided by b is: {modulus}");
            }
            catch (OverflowException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }




            Console.ReadKey();
        }
    }
}
