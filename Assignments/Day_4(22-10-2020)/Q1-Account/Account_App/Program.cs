//Q1. Create a class Account having private instance member Id, Name Balanceamt. Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder. Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder. Write method display which will display name and Balanceamt. This application will be classlibrary.
//Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.

using System;
using AccLib;

namespace Account_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Press Enter To Start The App.");
            //User 1 Object
            Console.WriteLine("\nEnter 1st User Name:");
            Account a1 = new Account(Console.ReadLine());       //obj 2/user 2 initialised
            a1.disp();                                          //initial disp no balance
            Console.Write("Deposit in acc 2 \nAmount : ");      //Depositing amount 
            a1.deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Withdraw from acc 1\nAmount : ");    //Withdrawing amount
            a1.withdraw(double.Parse(Console.ReadLine()));

            //User 2 Object
            Console.WriteLine("Enter 2nd User Name:");
            Account a2 = new Account(Console.ReadLine());       //obj 2/user 2 initialised
            a2.disp();
            Console.Write("Deposit in acc 2 \nAmount : ");
            a2.deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Withdraw from acc 2\nAmount : ");
            a2.withdraw(double.Parse(Console.ReadLine()));
            Console.ReadLine();
        }       
    }
}
