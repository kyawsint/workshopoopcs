using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class BankAccount
    {
        private string accountno, accountholder;
        static double balance;

        public BankAccount(string an, string ah, double bal)
        {
            accountno = an;
            accountholder = ah;
            balance = bal;
            Console.WriteLine("Account Details : {0}, {1}, {2}.", accountno, accountholder, balance);
        }

        public string Accountno
        {
            get { return accountno; }
            set { value = accountno; }
        }

        public string Accountholder
        {
            get { return accountholder; }
            set { value = accountholder; }
        }

        public double Balance 
        {
            get { return balance; }
            set { value = balance; }
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your account balance : {0}.", balance);
        }

        public void Withdraw(double wd)
        {
            double draw = wd;
            if (wd <= balance && wd > 0)
            {
                balance = balance - wd;
                Console.WriteLine("Cash amount : {0} and Available amount : {1}.", draw, balance);
            }
            else
                CheckBalance();
        }

        public void Deposit(double bal)
        {
            balance += bal;
            Console.WriteLine("Successful deposit! Now available amount is {0}.", balance);
        }

        public void TransferTo(BankAccount2 ba,double amount)
        {
            double trans = amount;
            if (trans <= balance && trans >= 0)
            {
                balance = balance - trans;
                ba.Deposit(trans);
                Console.WriteLine("Successfully tranfer! {0} is already transfer and available balance is {1}.", trans, balance);
            }
            else { Console.WriteLine("Insufficient amount!. Try again."); CheckBalance(); }
        }
    }


    class BankAccount2
    {
        private string accountno;
        Customer accountholder;
        static double balance;

        public BankAccount2() { }

        public BankAccount2(string an, Customer cus, double bal)
        {
            accountno = an;
            accountholder = cus;
            balance = bal;
            Console.WriteLine("Account Details : {0}, {1}, {2}.", accountno, accountholder.Name, balance);
        }

        public string Accountno
        {
            get { return accountno; }
            set { value = accountno; }
        }

        public Customer Accountholder
        {
            get { return accountholder; }
            set { value = accountholder; }
        }

        public double Balance
        {
            get { return balance; }
            set { value = balance; }
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your account balance : {0}.", balance);
        }

        public void OwnerInfo()
        {
            Console.WriteLine("Account Holder : {0}\nAddress : {1}\nNIRC : {2}\nAge : {3}", accountholder.Name, accountholder.Address, accountholder.NIRC, accountholder.Age());
        }

        public void Withdraw(double wd)
        {
            double draw = wd;
            if (wd <= balance && wd > 0)
            {
                balance = balance - wd;
                Console.WriteLine("Cash amount : {0} and Available amount : {1}.", draw, balance);
            }
            else
                CheckBalance();
        }

        public void Deposit(double bal)
        {
            balance += bal;
            Console.WriteLine("Successful deposit! Now available amount is {0}.", balance);
        }

        public void TransferTo(BankAccount ba, double amount)
        {
            double trans = amount;
            if (trans <= balance && trans >= 0)
            {
                balance = balance - trans;
                ba.Deposit(trans);
                Console.WriteLine("Successfully tranfer! {0} is already transfer and available balance is {1}.", trans, balance);
            }
            else { Console.WriteLine("Insufficient amount"); CheckBalance(); }
        }
    }
}
