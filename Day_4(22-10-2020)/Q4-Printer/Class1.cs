using System;

namespace print_lib
{
    public class Printer
    {
        static Printer()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n*********Printer Singleton**********\n");
            Console.WriteLine("----------------------------------------");
        }

        private static Printer p;
        private Printer()
        {
        }

        public static Printer getPrinter()
        {
            if(p == null)
                p = new Printer();
            return p;
        }
    }
}
