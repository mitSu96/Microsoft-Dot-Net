//Q1. Create a class Employee having member variable Firstname, Lastname, Middlename.let your application create object even if user does not enter Middlename. Create two constructor one take parameter for Firstname, Lastname and second constructor which will take all the parameter. Write display method which will display detail of the object.

using System;
using Emp_Lib;

namespace Q1_Employee_MiddlenameMissing_
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n****************Corporation Of Unknowns***************\n");
            Console.WriteLine("-----------------------------------------------------\n");
        }

        static void Main(string[] args)
        {
            int ch;
            string Fname, Mname, Lname;
            Employee e1;
            //Employee e2;
            do {
                Console.Write("\n        Enter Name Of Employee \n\nFirst Name : ");
                Fname = Console.ReadLine();
                Console.Write("Middle Name : ");
                Mname = Console.ReadLine();
                Console.Write("Last Name : ");
                Lname = Console.ReadLine();
               // Console.WriteLine("{0} {1} {2}", Fname,Mname, Lname);

                if(Mname == null)
                     e1 = new Employee(Fname,Lname);
                else
                     e1 = new Employee(Fname, Mname ,Lname);
                e1.disp();
                //e2.disp();
                Console.WriteLine("\n\nEnter 0 to Exit\n\nElse 1 to Continue The Application...");
                Console.WriteLine("\n-----------------------------------------------------\n");
                ch=int.Parse(Console.ReadLine());
            } while (ch != 0);
        }
    }
}
