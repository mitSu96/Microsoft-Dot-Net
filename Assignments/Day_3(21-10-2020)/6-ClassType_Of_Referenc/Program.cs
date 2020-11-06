//Q6. Create a class having instance member salary. Create a object of a class. Print data type of reference of a class also print parent class name.

using System;
using sal_lib;

namespace _6_ClassType_Of_Referenc
{
    class Program
    {
        public class emp1 
        {
        public float salary1;
        }

    
        static void Main(string[] args)
        {
            Console.Write("---------Data type of Reference of a class & its parent class name from a library file-----------\n");
            emp e1 = new emp();
            Console.WriteLine("\nType of ref of employee e1 : {0}\nparent of employee e1 : {1}", e1.GetType(), e1.GetType().BaseType);
            Console.WriteLine("Type of salary  : {0}", e1.salary.GetType());
            Console.Write("\n\n---------Data type of Reference of a class & its parent class name from same file(sal-float)-------\n");
            emp1 e2 = new emp1();
            Console.WriteLine("\nType of ref of employee e2 : {0}\nparent of employee e2 : {1}", e2.GetType(), e2.GetType().BaseType);
            Console.WriteLine("Type of salary  : {0}", e2.salary1.GetType());

            Console.ReadLine();
        }
    }
}
