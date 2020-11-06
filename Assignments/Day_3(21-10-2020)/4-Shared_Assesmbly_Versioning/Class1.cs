/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Shared_Assesmbly_Versioning
{
    class Class1
    {
    }
}
//Part 2 using versioning of library to call additional method from same same file
using System;
using mycalculator;

namespace _4_Shared_Assesmbly_Versioning
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 2 of mycalculator shared assembly lib versioned ");
            Console.WriteLine("\nEnter The 2 Numbers To Be Added & Multiplied.");
            int a, b;
            Console.WriteLine("\nEnter Number 1 :");
            bool a1 = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("\nEnter Number 2 :");
            bool b1 = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("\n1]The Addition Of " + a + " & " + b + " : " + calc.add(a, b));
            Console.WriteLine("\n2]The Product Of " + a + " & " + b + " : " + calc.prod(a, b));
            Console.Write("\nHit Enter To Continue\n");
            Console.ReadLine();
            Console.WriteLine("\nEnter Number To Be Cubed :");
            int c;
            bool c1 = int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("\n3]The Cube Of " + c + " : " + calc.cube(c));
            Console.ReadLine();
        }
    }
}
*/