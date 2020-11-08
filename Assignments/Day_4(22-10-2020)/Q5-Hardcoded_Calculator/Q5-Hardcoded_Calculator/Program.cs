using System;
using Cal_Lib;

namespace Q5_Hardcoded_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter To Start The Hard-Coded application");
            Console.ReadLine();
            float sqr = Calculator.square(22);
            float cube = Calculator.cube(22);
            /*double abs = Calculator.absolute(2.2);
            double flr = Calculator.floor(2.7);
            double ceil = Calculator.ceil(2.9);*/

            Console.WriteLine("Square={0}   Cube= {1}   Absolute={2}    Floor={3}   Ceil={4}", sqr, cube, Math.Abs(-2.8), Math.Floor(2.7), Math.Ceiling(2.9));
            Console.ReadLine();
        }
    }
}
