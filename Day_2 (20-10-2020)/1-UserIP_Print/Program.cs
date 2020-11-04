//Q1. Accept two number from user and print sum of it.

using System;

namespace _1_UserIP_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Two Numbers\n");
            //Console.WriteLine();
            string a, b;
            float c, d;
            Console.WriteLine("Enter The Two Numbers To Be Added:");
            a = Console.ReadLine();
            b = Console.ReadLine();

            bool a1 = float.TryParse(a, out c);
            bool a2 = float.TryParse(b, out d);


            if (a1 = a2 == true)
                //Console.WriteLine();
                Console.WriteLine("\nSum Of Two Numbers " + a + " & " + b + " is Equal to " + (c + d));
                Console.ReadLine();

        }
    }
}


//here we are using bool so as to check whther the data input in stream is number or not 
//also we use tryparse because TryParse is the best method to convert string to number as it will return Boolean value .
