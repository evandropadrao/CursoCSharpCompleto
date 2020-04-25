using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Interface.Entitites;
using Exercicio_Interface.Services;

namespace Exercicio_Interface.Services
{
   class PaypalService : IOnlinePaymentService
   {
      double IOnlinePaymentService.Interest(double amount, int months)
      {
         return amount = amount * 0.01 * months;
      }

      double IOnlinePaymentService.PaymentFee(double amount)
      {
         return amount = amount * 0.02;
      }
   }
}
