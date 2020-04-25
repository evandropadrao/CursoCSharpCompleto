using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Interface.Entitites;

namespace Exercicio_Interface.Services
{
   class ContractService
   {
      private IOnlinePaymentService _paymentService;

      public ContractService(IOnlinePaymentService onlinePaymentService)
      {
         _paymentService = onlinePaymentService;
      }

      public void ProcessContract(Contract contract, int months)
      {
         double quota = contract.TotalValue / months;

         for (int i = 1; i <= months; i++)
         {
            double interest = quota + _paymentService.Interest(quota, i);
            double totalPayment = interest + _paymentService.PaymentFee(interest);

            contract.AddInstallment(new Installment(contract.Date.AddMonths(i), totalPayment));
         }
      }
   }
}
