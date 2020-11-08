//Q2. Create a class Employee having private instance member Id, Name Salary, netsalary. Create method calculate_netsalary who’s job is to deduct 10% of TDS.. Write method display which will display name and netsalary. This application will be classlibrary.
//Create console application and use this class library. Create at least two object of Employee class 

using System;
using Emp_Lib;
namespace Q2_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************Employee Application**********************\n");
            
            //user 1 object
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter the name of employee 1 : \n");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter Employee {0}'s Salary : ", n1);
            double s1 = double.Parse(Console.ReadLine());
            Employee e1 = new Employee(n1, s1);
            e1.disp();
            Console.WriteLine("\nHit Enter To Create Employee 2\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadLine();

            //user 1 object
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter the name of employee 2 : \n");
            string n2 = Console.ReadLine();
            Console.WriteLine("Enter Employee {0}'s Salary : ", n1);
            double s2 = double.Parse(Console.ReadLine());
            Employee e2 = new Employee(n2, s2);
            e1.disp();
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
