using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Interface.Entitites;
using Exercicio_Interface.Services;

namespace Exercicio_Interface
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Enter contract data:");

         Console.Write("Number: ");
         int number = int.Parse(Console.ReadLine());
         Console.Write("Date (dd/MM/yyyy): ");
         DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
         Console.Write("Contract value: ");
         double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         Contract contract = new Contract(number, date, value);

         Console.Write("Enter number of installments: : ");
         int installments = int.Parse(Console.ReadLine());

         ContractService contractService = new ContractService(new PaypalService());
         contractService.ProcessContract(contract, installments);


         Console.WriteLine();
         Console.WriteLine("Installments: ");

         List<Installment> listOfInstallments = contract.GetInstallments();
         foreach (var installment in listOfInstallments)
         {
            Console.WriteLine(installment);
         }
      }
   }
}
