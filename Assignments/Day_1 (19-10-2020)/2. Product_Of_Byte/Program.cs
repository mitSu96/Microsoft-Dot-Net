//Q2. Declare 2  variable of a type byte and print product of it.


using System;

namespace Product_Of_Byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product of Two Byte");
            byte x = 1, y = 20;
            //byte z; here as z is byte error: Cannot implicitly convert type 'int' to 'byte'. An explicit conversion exists (are you missing a cast?)
            int z;
            z = x * y;

            Console.WriteLine("Product of " + x + " & " + y + "If Variable Is Declared As Int = " + z);
            Console.ReadLine();
            Console.WriteLine("Typecasting To Byte:");
            byte a = (byte)(x * y);
            Console.WriteLine("Typecast result=" + a);
            Console.ReadLine();

        }
    }
}

//Here In this assignment we came to know that addition/product of two byte is int or we have to explicitly store it by downcasting the sum to byte 
//ie. byte a,b,c; a = b+c ; returns error as the product is int and cant be stored in byte we need to declare a as int to store the sum of b & c.
//or byte a,b,c; a= (byte)(b+c);  will return the value as now the sum is downcasted to byte.

