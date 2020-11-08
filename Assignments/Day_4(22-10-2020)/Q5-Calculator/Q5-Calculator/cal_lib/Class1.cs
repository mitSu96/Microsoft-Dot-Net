using System;

namespace cal_lib
{
    public class Calculator
    {
        static Calculator()
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("\n*******Calculator Application Menu Driven.*********\n");
            Console.WriteLine("--------------------------------------------\n");
        }
        public static float square(float n){
            return n*n;
        }

        public static float cube(float n) {
            return n * n * n;
        }

        public static float absolute(float n) {
            return Math.Abs(n);
        }

        public static float floor(float n) { return (float)Math.Floor(n); }

        public static float ceil(float n) { return (float)Math.Ceiling(n); }
    
    }

}
