//Q4. Create class library “mycaculator” having instance method  add and product which will return sum and product of two number.  Create shared assembly and use in your project. After  this add method cube  to a copy of class library “mycaculator” change the version and add it to GAC. Create a application to use this new version of library. Ensure that your both console application works.

using System;
using mycalculator;

namespace _4_Shared_Assesmbly_Versioning
{
    class Program
    {
        static void Main
            (string[] args)
        {
            Console.WriteLine("Part 1 of mycalculator shared assembly lib");
            Console.WriteLine("\nEnter The 2 Numbers To Be Added & Multiplied.");
            int a, b;
            Console.WriteLine("\nEnter Number 1 :");
            bool a1 = int.TryParse(Console.ReadLine() , out a);
            Console.WriteLine("\nEnter Number 2 :");
            bool b1 = int.TryParse(Console.ReadLine() , out b);
            Console.WriteLine("\nThe Addition Of " + a + " & " + b + " : " + calc.add(a,b));
            Console.WriteLine("\nThe Product Of " + a + " & " + b + " : " + calc.prod(a, b));
            Console.ReadLine();
        }
    }
}
