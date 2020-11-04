//Q2. Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.

using System;

namespace _2_Calculator_Struct
{
    public struct calculator
    {
        public static void factor(int n)
        {
            Console.Write("\nFactors of {0} : " , n);
            for (int i = 1; i < n; i++)
            {
                //Console.WriteLine("[");
                if (n % i == 0)
                {
                    Console.Write(" [{0}", i + "] ,");            //also we can write as (" "+i);
                }
                //Console.WriteLine(n);
            }
            Console.WriteLine("[" + n + "].");
        }
    }
}

//here we can reduce two lines of code by writing i<=n which will print n at the end but would give a , at the end which looks like the factors are incomplete so we added 2 lines of extra code.