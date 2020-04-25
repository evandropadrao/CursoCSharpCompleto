using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Services
{
   class USPaylpalService : IOnlinePaymentService
   {
      private const double InterestRate = 0.005;
      private const double FeeRate = 0.015;

      double IOnlinePaymentService.Interest(double amount, int months)
      {
         return amount = amount * InterestRate * months;
      }

      double IOnlinePaymentService.PaymentFee(double amount)
      {
         return amount = amount * FeeRate;
      }
   }
}
