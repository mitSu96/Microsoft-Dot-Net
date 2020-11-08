using System;

namespace AccLib
{
    public class Account
    {
        static Account()                //bank name to be dispalyed as soon as app is called and only once
        {
            Console.WriteLine("\n****************Bank Of Unknown*****************\n");
        }

        static int id_def = 202020;           //here id_def is kept static because its value should be kept by the bank & incremented/accessed according to new user.
        int id;                             //displayed id 
        string name;
        double bal = 0;                     //balance set as double & initialised to zero

        public Account(string name)
        {
            this.id = ++id_def;
            this.name = name;
        }

        public void deposit(double amt)
        {
            this.bal += amt;                //here it means balance_amt = amount_deposited + Previous_balanceamt;
            disp();
        }

        public void withdraw(double amt)
        {
            if (bal <= amt)
            {
                Console.WriteLine("\n*******Insufficient Balance Cant Withdraw The Money From Your Account " + name + " ******");
                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                bal -= amt;
                disp();
            }
        }

        public void disp()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("ACCOUNT NUMBER : {0}\nName Of Account Holder : {1}\nBalance : {2}", id, name, bal);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
