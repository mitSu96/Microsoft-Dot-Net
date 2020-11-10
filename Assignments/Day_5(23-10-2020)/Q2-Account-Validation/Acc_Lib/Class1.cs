using System;

namespace Acc_Lib
{
    public class Account
    {
        int id;
        static int getid;
        string name;
        double bal;
        const int max_Acc = 3;              //in question it is asked to create only 3 object if 4th is created should dispaly a message so using max_acc to count.
        const double minBal = 1000;         //min balance to withdraw if higher it allows else doesnt let the transaction.

        public Account(string name)
        {
            this.id = ++getid;
            if (id > max_Acc)       //here checking if the id generation is greater than three
                throw new Exception("\nMaximum Number Of Accounts Reached.Can't Create New Account Objects.");          //throws an exception
            this.name = name;           //this will display the name of customer instance created.
            this.bal = minBal;             //this will always show th min balanace athe time of acc creation
        }

            //deposit
        public void Deposit(double amt)             //using void because we take input from user and save it for durther use 
        {
            this.bal += amt;                        //increment the balance
            disp();
        }

            //withdrawal
        public void Withdraw(double amt)
        {
            if (bal - amt <= minBal)
                Console.WriteLine("Minimum Balance Is Low So Transaction Cannot Be Fulfilled'");
            else
            this.bal -= amt;                        //decrements the balance
            disp();
        }

             //Display the details
        public void disp()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------");
            Console.WriteLine("Id : {0}\nName : {1}\nBalance : {2}", id, name, bal);
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }

    }
}
