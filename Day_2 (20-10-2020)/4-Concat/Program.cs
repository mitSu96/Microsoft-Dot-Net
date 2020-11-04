//Q4. Accept two name from user and concat.

using System;

namespace _4_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatination Of Two Names.\n");
            Console.WriteLine("Enter 1st Name: ");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Name: ");
            String str2 = Console.ReadLine();
            Console.WriteLine("Hit enter To Concat The Two Names.\n");
            Console.ReadLine();
            Console.WriteLine("Concated Name   :  " + str1+str2);
            Console.ReadLine();
        }
    }
}
