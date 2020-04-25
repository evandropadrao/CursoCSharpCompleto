using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Entitites
{
   class Contract
   {
      public int Number { get; private set; }
      public DateTime Date { get; private set; }
      public double TotalValue { get; private set; }
      public int MyProperty { get; set; }
      public List<Installment> _installments { get; set; } = new List<Installment>();

      public Contract(int number, DateTime date, double totalValue)
      {
         Number = number;
         Date = date;
         TotalValue = totalValue;
      }

      public void AddInstallment(Installment installment)
      {
         _installments.Add(installment);
      }

      public List<Installment> GetInstallments()
      {
         return _installments;
      }
   }
}
