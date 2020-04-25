using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_MetodosAbstratos.Entities;

namespace Exercicio_MetodosAbstratos
{
   class Program
   {
      static void Main(string[] args)
      {
         List<TaxPayer> list = new List<TaxPayer>();

         Console.Write("Enter the number of tax payers: ");
         int count = int.Parse(Console.ReadLine());

         for (int i = 1; i <= count; i++)
         {
            Console.WriteLine();
            Console.WriteLine($"Tax payer #{i} data:");

            Console.Write("Individual or company (i/c)? ");
            char type = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Annual income: ");
            double  income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (type == 'i')
            {
               Console.Write("Health expenditures: ");
               double healtExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               list.Add(new Individual(name, income, healtExpenditures));
            }
            else
            {
               Console.Write("Number of employees: ");
               int numOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               list.Add(new Company(name, income, numOfEmployees));
            }
         }

         Console.WriteLine();
         Console.WriteLine("TAXES PAID:");

         double sum = 0.0;
         foreach (var tax in list)
         {
            Console.WriteLine($"{tax.Name}: $ {tax.Tax().ToString("F2")}", CultureInfo.InvariantCulture);

            sum += tax.Tax();
         }

         Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2")}", CultureInfo.InvariantCulture);
      }
   }
}
