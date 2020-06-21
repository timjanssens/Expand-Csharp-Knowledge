using System;

namespace H9._4ReadValidInt
{
    class Program
    {
        static void Main(string[] args)
        {


            int valueA = ReadValidInt("Enter a valid integer: ");
            int valueB = ReadValidInt("Enter a valid integer: ");

            int sum = GetSum(valueA, valueB);

            Console.WriteLine($"{valueA} + {valueB} = {sum}");


            Console.ReadKey();
        }

        private static int ReadValidInt(string question)
        {
            bool valid = true;
            Console.Write(question);

            int valueA = 0;
            while (valid)
            {

                try
                {
                    valueA = int.Parse(Console.ReadLine());
                    valid = false;
                }
                catch (Exception)
                {

                    Console.Write("Not a valid number. Give another one: ");
                }
            }

            return valueA;

        }

        private static int GetSum(int valueA, int valueB)
        {
            int sum = 0;

            try
            {
                checked
                {
                    sum = valueA + valueB;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your numbers are to high for an integer");
            }



            return sum;
        }

    }
}
