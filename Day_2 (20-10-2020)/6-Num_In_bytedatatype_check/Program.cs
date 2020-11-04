//Q6. Accept a number and stored it in byte data type check what happen if you enter 258?

using System;

namespace _6_Num_In_bytedatatype_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Chewck What Happens When We Use 258 For ip In Byte Datatype\n");
            Console.WriteLine("Enter A Number: ");
            string num = Console.ReadLine();
            byte b = byte.Parse(num);
            Console.WriteLine("Data Stored In Byte: " + b);
            Console.ReadLine();
        }
    }
}

//here we give 256 or above as input we get a  error: OverFlowException  Value Too Big Or too Small for Unsigned Byte & the prg exits.
