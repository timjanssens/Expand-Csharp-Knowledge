using System;

namespace H9._5ShowDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wich character do you want to use?");
            char chosenChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            const int minCharLine = 10;
            const int maxCharLine = 100;
            const int minTime = 1;
            const int maxTime = 1000;

            int charTimesPerLine = ReadNumberWriteMessage($"How many times do you want this char on a line? The number must be bigger than {minCharLine} and smaller than {maxCharLine}", minCharLine, maxCharLine);
            int timelimit = ReadNumberWriteMessage($"How many milliseconds do you want to pause between each line? The number must be bigger than {minTime} and smaller than {maxTime}", minTime, maxTime);




            Console.ReadKey();
        }

        /// <summary>
        /// checks if the number is between the min and max value of the parameters
        /// </summary>
        /// <param name="message"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int ReadNumberWriteMessage(string message, int min, int max)
        {

            Console.WriteLine(message);
            int charTimesPerLine = ReadNumberWriteMessage($"That is not valid, please give a number: ");

            while (true)
            {
                if (charTimesPerLine < min)
                {
                    Console.WriteLine($"please enter a number higher then {min}: ");
                    charTimesPerLine = ReadNumberWriteMessage($"That is not valid, please give a number: ");
                }
                else if (charTimesPerLine > max)
                {
                    Console.WriteLine($"Please enter a number lower then {max}: ");
                    charTimesPerLine = ReadNumberWriteMessage($"That is not valid, please give a number: ");
                }
                else
                    break;
            }


            return charTimesPerLine;
        }

        /// <summary>
        /// check if there is an int as input
        /// </summary>
        /// <param name="message">message when someone types in an invalid character</param>
        /// <returns></returns>
        public static int ReadNumberWriteMessage(string message)
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch (Exception)
                {
                    Console.Write(message);
                }
            }
        }
    }
}
