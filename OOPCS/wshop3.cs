using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class wshop3
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2000, 2, 8, 12, 30, 30);
            DateTime dt1 = new DateTime(1999, 2, 8, 12, 30, 30);
            Customer cus = new Customer("KS", "Clementi Ave 2", "G12312L", dt);
            Customer cus1 = new Customer("MMT", "Clementi Ave 2", "G213122Q", dt1);
            BankAccount ba = new BankAccount("1234","KS",1000);
            BankAccount2 ba2 = new BankAccount2("56789", cus1, 500);

            // BankAccount
            Console.WriteLine("BankAccount One.");
            ba.CheckBalance();
            ba.Deposit(10);
            ba.Withdraw(100);
            ba.TransferTo(ba2, 500);

            // BankAccount2
            Console.WriteLine("\nBankAccount Two.");
            ba2.OwnerInfo();
            ba2.CheckBalance();
            ba2.Deposit(50);
            ba2.Withdraw(150);
            ba2.TransferTo(ba, 11.20);

            // Customer
            Console.WriteLine("\nCustomer Information.");
            Console.WriteLine("Customer Name : {0} and Age : {1}.", cus.Name, cus.Age());
        }
    }
}
