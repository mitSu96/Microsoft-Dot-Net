//Q2. Create a class library which will return square, cube of a number. [Create private Assembly]

using System;
using priv_lib;

namespace _2_Private_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Private Assembly Class Kibrary Operation.\n");
            string x;
            int a;
            Console.WriteLine("Enter a number to be operated");
            x = Console.ReadLine();


            bool a1 = int.TryParse(x, out  a);

            if (a1 == true)
                Console.WriteLine("\nSquare Of " + x +" is " + operation.square(a));
                Console.WriteLine("\nCube Of " + x + " is " + operation.cube(a));
                Console.ReadLine();

        }
    }
}

