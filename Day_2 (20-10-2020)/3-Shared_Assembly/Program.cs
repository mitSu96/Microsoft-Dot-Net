//Q3. Create a class library which will return square, cube of a number. [Create shared Assembly]

using System;
using shared_lib;

namespace _3_Shared_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shared Assembly Class Library Operation.\n");
            string x;
            int a;
            Console.WriteLine("Enter a number to be operated");
            x = Console.ReadLine();


            bool a1 = int.TryParse(x, out  a);

            if (a1 == true)
                Console.WriteLine("\nSquare Of " + x + " is " + operation.square(a));
            Console.WriteLine("\nCube Of " + x + " is " + operation.cube(a));
            Console.ReadLine();

        }
    }
}
