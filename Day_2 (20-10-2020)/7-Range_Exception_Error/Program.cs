//Q7. . Accept a number and stored it in byte data type if it goes beyond range throw exception

using System;

namespace _7_Range_Exception_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Chewck What Happens When We Use 258 For ip In Byte Datatype\n");
            Console.WriteLine("Enter Number: ");
            string num = Console.ReadLine();
            /*int res;
            bool temp = int.TryParse(num, out res);
            if (temp == true)*/
            try
            {
                byte b = byte.Parse(num);
                Console.WriteLine("Data: " + b);
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: '{0}' ", num + " was either too large or too small for an unsigned byte.");

                //System.OverflowExcepion {"num was either too large or too small for an unsigned byte."};
            }
            Console.ReadLine();
        }
    }
}
