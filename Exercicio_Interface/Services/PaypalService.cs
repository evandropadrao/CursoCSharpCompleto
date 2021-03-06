﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Interface.Entitites;
using Exercicio_Interface.Services;

namespace Exercicio_Interface.Services
{
   class PaypalService : IOnlinePaymentService
   {
      private const double InterestRate = 0.01;
      private const double FeeRate = 0.02;

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
