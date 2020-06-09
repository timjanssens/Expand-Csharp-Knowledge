using System;
using System.Xml.Schema;

namespace H9._2PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberTill = 0;
            int primeCoutner = 0;

            try
            {
                Console.WriteLine("Till witch number do you want to get prime numbers");
                numberTill = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid number");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }



            Console.WriteLine("Found Primes:");

            for (int i = 0; i <= numberTill; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i);
                    primeCoutner++;
                }
            }

            Console.WriteLine($"Found {primeCoutner} primes");



            Console.ReadKey();
        }

        private static bool CheckPrime(int num)
        {
            if (num > 1)
            {

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            return false;

        }
    }
}
