//Q3. Create a class customer having member Id, name, billamount. When you create a object allow to have default vale. Print default value of id,name, billamount.

using System;
using Cust_lib;

namespace Q3_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter The Name Of Customer");
            Customer c1 = new Customer();
            c1.disp();
            Console.ReadLine();

        }
    }
}
