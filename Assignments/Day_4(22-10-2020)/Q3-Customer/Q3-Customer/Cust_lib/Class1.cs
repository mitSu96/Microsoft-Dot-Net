using System;

namespace Cust_lib
{
    public class Customer              //default access modifier internal
    {
        static Customer()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\n****Customer Billing Desk By Razorpay Solution****\n");
            Console.WriteLine("--------------------------------------------------");
        }

        //static int id_def=2020;
        int id;
        string name;
        double billamount;

        public Customer()
        {
            Console.WriteLine("\nInitializing default value as no constructor is used.\n");      //if you do not write constructor frame work will give you no args constructor
        }
        

        /*public Customer(string name)
        {
            this.id = ++id_def;
            this.name = name;
        }*/

            public void disp()
            {
                Console.WriteLine("id : {0}\nName Of Customer : {1}\nBill Amount : {2}" ,id,name,billamount);
            }
    }
}
