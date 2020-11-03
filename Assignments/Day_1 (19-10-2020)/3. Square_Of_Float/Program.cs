//Q3.  Declare a variable of a type float and print square of it after storing it in to a variable.

using System;

namespace _3.Square_Of_Float
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 21.69f;
            float z;
            z = x * x;

            Console.WriteLine("Square Of Float " + x + " Is");
            Console.ReadLine();
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
