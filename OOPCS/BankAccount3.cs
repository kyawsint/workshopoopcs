using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class BankAccount3:BankAccount2
    {
        private double interestrate;

        public double Interestrate
        {
            get { return interestrate; }
            set { interestrate = value; }
        }

        public BankAccount3() { }

        public BankAccount3(string an, Customer cus, double bal) : base(an, cus, bal) { }

        public new bool CheckBalance()
        {
            if (Balance >= 0)
            {
                return true;
            }
            else return false;
        }

        public double CalculateInterest()
        {
            double cald = 0;
            return cald;
        }

        public void CreditInterest() { }
    }

    class SavingsAccount : BankAccount3
    {
        public SavingsAccount() { }

        public SavingsAccount(string an,Customer cus, double bal, double d) : base(an,cus,bal)
        {
            Interestrate = d/100;
            //Console.WriteLine("Account Details : {0}.", Interestrate);
        }

        public new double CalculateInterest()
        {
            double calint=0;
            if (CheckBalance())
            {
                calint = Balance * Interestrate;
                return calint;
            }
            else
            { return calint; }
        }

        public new void CreditInterest()
        {
            double creint=0;
            if (this.CalculateInterest() > 0)
            {
                creint = Balance + CalculateInterest();
                Console.WriteLine("Savings Account credit interest : {0}.", creint);
            }
        }
    }

    class CurrentAccount : BankAccount3
    {
        public CurrentAccount() { }

        public CurrentAccount(string an, Customer cus, double bal, double d) : base(an, cus, bal) { Interestrate = d / 100; }
        
        public new double CalculateInterest()
        {
            double calint = 0;
            if (CheckBalance())
            {
                calint = Balance * Interestrate;
                return calint;
            }
            else return calint;
        }

        public new void CreditInterest()
        {
            double creint = 0;
            if (this.CalculateInterest() > 0)
            {
                creint = Balance + this.CalculateInterest();
                Console.WriteLine("Current Account credit interest : {0}.", creint);
            } 
        }
    }

    class OtherDraftAccount : BankAccount3 
    {
        public OtherDraftAccount() { }

        public OtherDraftAccount(string an, Customer cus, double bal, double d) : base(an, cus, bal) { Interestrate = d / 100; }

        public new double CalculateInterest()
        {
            double calint=0;
            if (!CheckBalance())
            {
                calint = Balance * Interestrate;
                return calint;
            }
            else return calint;
        }

        public new void CreditInterest()
        {
            double creint = 0;
            if (this.CalculateInterest() < 0)
            {
                creint = Balance + this.CalculateInterest();
                Console.WriteLine("Other Draft Account credit interest : {0}.", creint);
            }
        }
    }
}
