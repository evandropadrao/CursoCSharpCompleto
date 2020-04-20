using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao01
{
   class ContaBancaria
   {
      public string Numero { get; private set; }
      public string Titular { get; set; }
      private double _saldo;
      private readonly double TaxaSaque = 5.00;

      public ContaBancaria(string numero, string titular)
      {
         Numero = numero;
         Titular = titular;
         _saldo = 0.0;
      }

      public ContaBancaria(string numero, string titular, double depositoInicial) : this(numero, titular)
      {
         _saldo = depositoInicial;
      }

      public void Deposito(double quantia)
      {
         _saldo += quantia;
      }

      public void Sacar(double quantia)
      {
         _saldo -= (quantia + TaxaSaque);
      }

      public override string ToString()
      {
         return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: R$ "
            + _saldo.ToString("F2", CultureInfo.InvariantCulture);
      }
   }
}
