using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_MetodosAbstratos.Entities
{
   class Company : TaxPayer
   {
      public int NumberOfEmployees { get; set; }

      public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
      {
         NumberOfEmployees = numberOfEmployees;
      }

      //Pessoa jurídica: pessoas jurídicas pagam 16% de imposto.Porém, se a empresa possuir mais de 10
      //funcionários, ela paga 14% de imposto.
      //Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
      //      400000 * 14% = 56000.00
      public override double Tax()
      {
         double tax;

         if (NumberOfEmployees > 10)
         {
            tax = AnnualIncome * 0.14;
         }
         else
         {
            tax = AnnualIncome * 0.16;
         }

         return tax;
      }
   }
}
