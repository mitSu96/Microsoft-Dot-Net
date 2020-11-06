//Q5. Accept a number from user and display its type and parent class.

using System;

namespace _5_Get_Base_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dispaly The Type & Parent Class Of Accepted Number.\n");
            Console.Write("Enter Number/Variable To Check the object type : ");
            var a = Console.ReadLine();
            Console.WriteLine("{0}\n{1}", a.GetType(), a.GetType().BaseType);  
            Console.Write("\nEnter Value to Check as the int type : ");
            int b;
            bool b1 = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("{0}\n{1}", b.GetType(), b.GetType().BaseType);
            Console.ReadLine();
        }
    }
}


//here if use var in readline we get the return from gettype as variable while when we use int in readline and parse it the return type is returned in int type (int32)