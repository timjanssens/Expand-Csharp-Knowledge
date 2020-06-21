using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLibrary
{
    public class DemoCode
    {

        public int GrandparentMethod(int position)
        {
            int output = 0;

            Console.WriteLine("Open Database Connection");

            try
            {
                output = ParentMethod(position);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("you gave us bad information. Bad user");
            }
            //catch (Exception ex)
            //{
            //    //do some logging
            //    throw new ArgumentException("you passed in bad data", ex);
            //}

            finally
            {
                Console.WriteLine("Close Database Connection");
            }


            return output;
        }
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);

            //}

            return output;
        }

    }
}
