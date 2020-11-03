//Q1. Declare 2 variable of a type short and store sum of it in a variable and print it.

using System;

namespace Sum_Of_Short
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x, y, z;
            int a;
            x = 1;
            y = 10;
            //z = x + y;     here as z is a byte we get:comesCannot implicitly convert type 'int' to 'byte'. An explicit conversion exists (are you missing a cast?)	D:\WorkSpace\PG-DAC Feb 2020\Microsoft .Net Technologies\Assignments\Day_1 (19-10-2020)\Sum_Of_Short\Sum_Of_Short\Program.cs	15	17	Sum_Of_Short

            a = x + y;      //to remove above error we typecast it using an int
            Console.WriteLine("Printing Of Short Type Using Int & By Typecasting(Hit Enter To See Results)");

            Console.WriteLine("The Sum Of Two Numbers " + x + " & " + y + " is");
            Console.ReadLine();
            Console.WriteLine("Sum inside int variable = " + a);
            Console.WriteLine("Typecasting Byte Variable ");
            z = (byte)(x + y);
            Console.ReadLine();
            Console.WriteLine("Typecast Result=" + a);
            Console.ReadLine();
        }
    }
}



//Here In this assignment we came to know that addition of two short is int or we have to explicitly store it by downcasting the sum to byte 
//ie. byte a,b,c; a = b+c ; returns error as the sum is int and cant be stored in byte we need to declare a as int to store the sum of b & c.
//or byte a,b,c; a= (byte)(b+c);  will return the value as now the sum is downcasted to byte.
