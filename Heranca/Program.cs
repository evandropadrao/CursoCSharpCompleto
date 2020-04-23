using System;
using Heranca.Entities;

namespace Heranca
{
   class Program
   {
      static void Main(string[] args)
      {
         Account acc = new Account(100, "Mary", 0.0);
         BusinessAccount bacc = new BusinessAccount(101, "John", 0.0, 200.0);

         // UPCASTING
         Account acc1 = bacc;
         Account acc2 = new BusinessAccount(102, "Roger", 0.0, 100.0);
         Account acc3 = new SavingsAccount(103, "Susan", 0.0, 0.02);

         // DOWNCASTING
         BusinessAccount bacc1 = (BusinessAccount)acc2;
         Console.WriteLine(bacc1.LoanLimit.ToString("F2"));

         // Compilador aceita, mas gera erro (Exception) em tempo de execucao
         //BusinessAccount bacc2 = (BusinessAccount)acc3;

         if (acc3 is BusinessAccount)
         {
            BusinessAccount bacc2 = (BusinessAccount)acc3;
            bacc2.Loan(55.00);
            Console.WriteLine("Final Balance: " + bacc2.Balance);
         }
         else
         {
            Console.WriteLine("Classes incompativeis ...");
         }

         if (acc3 is SavingsAccount)
         {
            SavingsAccount sacc1 = (SavingsAccount)acc3;
            sacc1.Deposit(56.00);
            sacc1.UpdateBalance();
            Console.WriteLine("Final Balance: " + sacc1.Balance.ToString("F2"));
         }
         else
         {
            Console.WriteLine("Classes incompativeis ...");
         }

         if (acc3 is SavingsAccount)
         {
            SavingsAccount sacc2 = acc3 as SavingsAccount;
            Console.WriteLine("Initial Balance: " + sacc2.Balance.ToString("F2"));
            sacc2.Deposit(80.00);
            sacc2.UpdateBalance();
            Console.WriteLine("Final Balance: " + sacc2.Balance.ToString("F2"));
         }
         else
         {
            Console.WriteLine("Classes incompativeis ...");
         }
      }
   }
}
