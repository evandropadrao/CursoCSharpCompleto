namespace Heranca.Entities
{
   class Account
   {
      public int Number { get; set; }
      public string Holder { get; set; }
      public double Balance { get; protected set; }

      public Account()
      {
      }

      public Account(int number, string holder, double balance)
      {
         Number = number;
         Holder = holder;
         Balance = balance;
      }

      public void Withdraw(double amount)
      {
         if (Balance <= amount)
         {
            Balance -= amount;
         }
         else
         {
            // invalid operation
         }
      }

      public void Deposit(double amount)
      {
         Balance += amount;
      }
   }
}
