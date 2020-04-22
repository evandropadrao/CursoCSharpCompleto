using System;
using System.Linq;
using System.Collections.Generic;
using ExercicioResolvido_01.Entities.Enum;

namespace ExercicioResolvido_01.Entities
{
   class Worker
   {
      public string Name { get; set; }
      public WorkLevel Level { get; set; }
      public double BaseSalary { get; set; }
      public Department Department { get; set; }
      public List<HourContract> Contracts { get; set; } = new List<HourContract>();

      public Worker()
      {
      }

      public Worker(string name, WorkLevel level, double baseSalary, Department department)
      {
         Name = name;
         Level = level;
         BaseSalary = baseSalary;
         Department = department;
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
         double income = BaseSalary;

         var contracts = Contracts.Where(x => (x.Date.Year == year) && (x.Date.Month == month));

         foreach (HourContract contract in contracts)
         {
            income += contract.TotalValue();
         }

         return income;
      }

      public override string ToString()
      {
         return Name
            + ", "
            + Level
            + ", "
            + BaseSalary
            +", "
            + Department.Name;
      }
   }
}
