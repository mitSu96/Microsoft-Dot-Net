//Q5. create a class demomaths having method Square , cube which will take float value and return square and cube of a number.

using System;

namespace _5.DemoMaths_Sqr_Cube
{
    class Program           //Entry Class Of Prg
    {
        static void Main(string[] args)
        {
            DemoMath myobj = new DemoMath(); //new is same as malloc
            //calling method using object reference
            float res1 = myobj.square(32.35f);
            float res2 = myobj.cube(32.35f);
            // + operator is overloaded it will concat
            Console.WriteLine("The Square & Cube Of 32.5f is");
            Console.ReadLine();
            Console.WriteLine("square={0},cube={1}", res1, res2);
            Console.ReadLine();
        }
    }

    class DemoMath
    {    //public instance method - you can call this method through object of this class
        public float square(float x)
        { return x * x; }

        public float cube(float x)
        { return x * x * x; }
    }
}
