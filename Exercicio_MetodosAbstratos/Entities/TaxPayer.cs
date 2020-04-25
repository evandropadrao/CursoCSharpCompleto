using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_MetodosAbstratos.Entities
{
   abstract class TaxPayer
   {
      public string Name { get; set; }
      public double AnnualIncome { get; set; }

      public TaxPayer()
      {
      }

      public TaxPayer(string name, double annualIncome)
      {
         Name = name;
         AnnualIncome = annualIncome;
      }

      public abstract double Tax();
   }
}
