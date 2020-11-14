using System;

namespace acc_lib
{
        //Invalid Amount I/p Exception
    public class InvalidAmtEx : Exception
    {
        public InvalidAmtEx()
        { 
        }
    }
        //Min Balance Exception
    public class MinBalEx : Exception
    {
        public MinBalEx ()
        {
        }
    }

        //Main Class Account
    public class Account
    {
        static int getId;
        readonly int _id;
        string _name;
        double _bal;
        static double minbal = 1000;
        static float interestRate = (float)0.07;
        
            //Parameterised constructor to initialise the obj
        public Account (string name , double amt)
        {
            _id = ++getId;
            Name = name;
            if (amt < minbal)
                throw new MinBalEx();
            else
                Balance = amt;
        }

            //readonly property ID
        public int id
        {
            get
            {
                return _id;
            }
        }

            //generate id & decrement it since in question we have max object creation limit
        public static void decGetId()
        {
            getId--;
        }

            //name of user vlaidation
        public string Name
        {
            set
            {
                if (value.Length != 0)
                    _name = value;
                else throw new Exception();
            }
            get { return _name; }
        }

            //Balance
        public double Balance
        {
            protected set { _bal = value; }
            get { return _bal; }
        }

            //Read Only Property-Interest
        public double Interest
        {
            get
            {
                return Balance*interestRate;
            }
        }

            //Printing/Display Method
        public void disp()
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("\nID : {0}\nName : {1}\nBalance : {2}\nInterest_Rate : {3}\n", id, Name, Balance, Interest);
            Console.WriteLine("-------------------------------------------------------------------\n");
        }


            //Deposit Method
        public void deposit(double amt)
        {
            if (amt <= 0)        //check if amount is zero or negative
                throw new InvalidAmtEx();         //throw excpetion
            else
                Balance = Balance + amt;        //else deposit & add the mone in balance
            disp();                             //dipslay after updating or deposit transaction
        }

            //Withdrawal Method
        public void withdrawl (double amt)
        {
            if (amt <= 0)       //if invalid withdrawal i/p
                throw new InvalidAmtEx();     //throw the exception
            if (_bal - amt < minbal )       //if the amount of withdrawal makes the balnace below the min balance limit
                throw new MinBalEx();
            Balance = Balance - amt;         //else deducte the amount from account for withrawal transactiomn & update the new balance
            disp();
        }


    }
}
