using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class wshop4
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2000, 2, 8, 12, 30, 30);
            Customer cus = new Customer("AAA", "Clementi Ave 2", "G12312L", dt);
            BankAccount3 ba = new BankAccount3("123", cus, 500);

            Console.WriteLine("\nSavings Account . . .");
            SavingsAccount sa = new SavingsAccount("Saving",cus,1000,1);
            Console.WriteLine("Savings Account interest rate : {0}.", sa.CalculateInterest()); 
            sa.CreditInterest();

            Console.WriteLine("\nCurrent Account . . .");
            CurrentAccount ca = new CurrentAccount("Current",cus,700,0.25);
            Console.WriteLine("Current Account interest : {0}", ca.CalculateInterest());
            ca.CreditInterest();

            Console.WriteLine("\nOther Draft Account . . .");
            OtherDraftAccount oa = new OtherDraftAccount("OverDraft",cus,900,6);
            Console.WriteLine("Other Draft Account interest : {0}.", oa.CalculateInterest());
            oa.CreditInterest();
            Console.WriteLine();
        }
    }
}
