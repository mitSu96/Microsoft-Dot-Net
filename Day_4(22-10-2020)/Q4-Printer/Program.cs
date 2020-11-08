//Q4. Create a class Printer with a private constructor. Your application should give only one reference of the printer object.

using System;
using print_lib;

namespace Q4_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = Printer.getPrinter();
            Printer p2 = Printer.getPrinter();

            if (p1.Equals(p2))
                Console.WriteLine("Same instance of printer ie.Objects are poniting to same instance");
            else
                Console.WriteLine("Different instances of printer");
            Console.ReadLine();
        }
    }
}
