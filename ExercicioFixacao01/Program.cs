using System;
using System.Globalization;

namespace ExercicioFixacao01
{
   class Program
   {
      static void Main(string[] args)
      {
         ContaBancaria conta1 = null;

         Console.Write("Entre o número da conta: ");
         string numeroConta = Console.ReadLine();

         Console.Write("Entre o titular da conta: ");
         string titularConta = Console.ReadLine();

         Console.Write("Haverá depósito inicial(s / n)? ");
         char opcao = char.Parse(Console.ReadLine());

         if (char.ToLower(opcao).Equals('s'))
         {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta1 = new ContaBancaria(numeroConta, titularConta, depositoInicial);
         }
         else
         {
            conta1 = new ContaBancaria(numeroConta, titularConta);
         }

         Console.WriteLine("Dados da conta:");
         Console.WriteLine(conta1);

         Console.Write("\nEntre um valor para depósito: ");
         double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         conta1.Deposito(valorDeposito);
         Console.WriteLine("Dados da conta atualizados:");
         Console.WriteLine(conta1);

         Console.Write("\nEntre um valor para saque: ");
         double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         conta1.Sacar(valorSaque);
         Console.WriteLine("Dados da conta atualizados:");
         Console.WriteLine(conta1);
      }
   }
}
