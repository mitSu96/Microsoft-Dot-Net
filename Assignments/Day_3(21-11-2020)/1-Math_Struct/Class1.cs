//Q1. Create a struct Math having two static method square and cube. Using struct variable call this method and print square and cube of a number

using System;

namespace _1_Math_Struct
{
    public struct math
    {
        public static double sqaure(int i)
        {
            return (i * i);
        }
        public static double cube(int i)
        {
            return (i * i * i);
        }
    }
}
