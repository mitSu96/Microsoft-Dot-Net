//main app for the struct questions 1-2-3

using System;
using _1_Math_Struct;                //using the lib created for q1-2-3
using _2_Calculator_Struct;
using _3_Emp_Struct;

namespace Q1_2_3_StructApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Math Struct Square & Cube Of Number\n");
            Console.WriteLine("Enter number To be squareed & cubed : ");
            int n;
            bool b = int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Square of {0} : {1}\nCube of {0} : {2}", n, math.sqaure(n), math.cube(n));         //calls the square & cube from math lib 

            Console.WriteLine("\n----------------------------------------------------------------\n");

            Console.WriteLine("2-Claculator Struct For Factorial Of Number\n");
            Console.WriteLine("Enter no to find factorial : ");
            int n1;
            bool b1 = int.TryParse(Console.ReadLine(), out n1);
            calculator.factor(n1);                          //calls the method from calculator lib factor method

            Console.WriteLine("\n----------------------------------------------------------------\n");

            Console.WriteLine("employee Details struct\n");
            Console.WriteLine("Enter Name Of Employee : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary Of Employee : ");
            double salary;
            bool b2 = double.TryParse(Console.ReadLine(), out salary);
            emp e1 = new emp(name, salary);                 //creating object of employee
            e1.disp_details();                              //displays the details of employee from emp lib
            Console.ReadLine();
        }
    }
}
