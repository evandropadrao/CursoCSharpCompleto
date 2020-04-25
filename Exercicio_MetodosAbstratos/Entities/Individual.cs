using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_MetodosAbstratos.Entities
{
   class Individual : TaxPayer
   {
      public double HealthExpenditures { get; set; }

      public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
      {
         HealthExpenditures = healthExpenditures;
      }


      //Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto.Pessoas com
      //renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
      //destes gastos são abatidos no imposto.
      //Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica:
      //      (50000 * 25%) - (2000 * 50%) = 11500.00
      public override double Tax()
      {
         double tax;

         if (AnnualIncome <= 20000)
         {
            tax = AnnualIncome * 0.15;
         }
         else
         {
            tax = AnnualIncome * 0.25;
         }

         tax -= (HealthExpenditures * 0.50);

         return tax;
      }
   }
}
