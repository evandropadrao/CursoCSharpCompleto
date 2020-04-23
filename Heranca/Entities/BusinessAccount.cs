namespace Heranca.Entities
{
   class BusinessAccount : Account
   {
      public double LoanLimit { get; set; }

      private double LoanRate = 10.00;

      public BusinessAccount()
      {
      }

      public BusinessAccount(double loanLimit)
      {
         LoanLimit = loanLimit;
      }

      public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
      {
         LoanLimit = loanLimit;
      }

      public void Loan(double amount)
      {
         if ((amount <= LoanLimit) && (amount >= LoanRate))
         {
            Balance += (amount - LoanRate);
         }
         else
         {
            // invalid operation
         }
      }
   }
}
