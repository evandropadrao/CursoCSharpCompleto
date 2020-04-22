using System;
using System.Collections.Generic;
using System.Text;
using ExercicioResolvido_01.Entities;
using ExercicioResolvido_01.Entities.Enum;

namespace ExercicioResolvido_01.Entities
{
   class Worker
   {
      public string Name { get; set; }
      public WorkLevel Level { get; set; }
      public double BaseSalary { get; set; }

      public List<HourContract> Contracts { get; set; }

      public Worker()
      {
      }

      public Worker(string name, WorkLevel level, double baseSalary)
      {
         Name = name ?? throw new ArgumentNullException(nameof(name));
         Level = level;
         BaseSalary = baseSalary;
      }

      public void AddContract(HourContract contract)
      {
         Contracts.Add(contract);
      }

      public void RemoveContract(HourContract contract)
      {
         Contracts.Remove(contract);
      }

      public double Income(int year, int month)
      {
         double income = 0.0;

         return income;
      }
   }
}
