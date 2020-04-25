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
         double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         Console.Write("Enter number of installments: : ");
         int installments = int.Parse(Console.ReadLine());

         BrazilianContract(number, date, amount, installments);

         USContract(number, date, amount, installments);
      }

      static void BrazilianContract(int number, DateTime date, double amount, int installments)
      {
         Console.WriteLine();
         Console.WriteLine("Brazilian Contract: ");

         Contract contract = new Contract(number, date, amount);

         ContractService contractService = new ContractService(new PaypalService());
         contractService.ProcessContract(contract, installments);

         ShowInstallments(contract.GetInstallments());
      }

      static void USContract(int number, DateTime date, double amount, int installments)
      {
         Console.WriteLine();
         Console.WriteLine("US Contract: ");

         Contract contract = new Contract(number, date, amount);

         ContractService contractService = new ContractService(new USPaylpalService());
         contractService.ProcessContract(contract, installments);

         ShowInstallments(contract.GetInstallments());
      }

      static void ShowInstallments(List<Installment> installments)
      {
         Console.WriteLine("Installments: ");

         foreach (var installment in installments)
         {
            Console.WriteLine(installment);
         }
      }
   }
}
