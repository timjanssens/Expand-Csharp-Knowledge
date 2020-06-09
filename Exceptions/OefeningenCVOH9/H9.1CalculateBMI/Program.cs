using System;

namespace H9._1CalculateBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, we are going to calculate your BMI.");

            try
            {
                Console.WriteLine($"{name}, how big are you (150cm is 1.5)?");
                double lenght = double.Parse(Console.ReadLine());

                Console.WriteLine($"{name}, how much do you weight in kg?");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine($"{name}, your BMI is {CalculateBMI(lenght, weight)}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Wrong input");
                
            }



            Console.ReadLine();
        }

        private static double CalculateBMI(double lenght, double weight) => weight / (lenght * lenght);

    }
}
