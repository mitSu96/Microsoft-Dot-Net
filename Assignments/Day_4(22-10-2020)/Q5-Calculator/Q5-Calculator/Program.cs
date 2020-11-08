//Q5. Create a class calculator having  static method square, cube, absolute, floor,ceil who’s job is to find square, cube, absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.

using System;
using cal_lib;

namespace Q5_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            float n;
            do
            {
                Console.WriteLine("\nEnter number to be operated : ");
                n = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter choice of opeartion on" + n + " : \n1.square\n2.cube\n3.absolute value\n4.floor\n5.Celing\n6.Exit\n");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Square of {0} : {1}\n", n, Calculator.square(n));
                        break;
                    case 2:
                        Console.WriteLine("Cube of {0} : {1}\n", n, Calculator.cube(n));
                        break;
                    case 3:
                        Console.WriteLine("Absolute value of {0} : {1}\n", n, Calculator.absolute(n));
                        break;
                    case 4:
                        Console.WriteLine("Floor of {0} : {1}\n", n, Calculator.floor(n));
                        break;
                    case 5:
                        Console.WriteLine("Ceil of {0} : {1}\n", n, Calculator.ceil(n));
                        break;
                    case 6:
                        Console.WriteLine("Exiting The Application.\n");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice from between 1 to 6");
                        break;
                }
            } while (ch != 6);
        }
    }
}
