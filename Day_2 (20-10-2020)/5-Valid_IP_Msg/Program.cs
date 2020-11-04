//Q5. Accept a number from user and print square of it, if input is not valid give appropriate message

using System;

namespace _5_Valid_IP_Msg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check If Input Is A number or not if not display message ekse print its square.\n");
            Console.WriteLine("Enter A Valid Number: \n");
            string num = Console.ReadLine();
            int res;
            bool temp = int.TryParse(num, out res);
            if (temp == true)
                Console.WriteLine("\nSquare Of " + num + " Is "  + (res * res));
            else
                Console.WriteLine( "\n" + num + " is an Invalid Input !!! Please Pass A Valid Numeric Valuse To Print The Square.");

            Console.ReadLine();
        }
    }
}
