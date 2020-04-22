using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioResolvido_01.Entities;
using ExercicioResolvido_01.Entities.Enum;

namespace ExercicioResolvido_01
{
   class Program
   {
      static void Main(string[] args)
      {
         HashSet<Worker> workers = new HashSet<Worker>();

         Console.Write("Enter department's name: ");
         string deptName = Console.ReadLine();
         Department department = new Department(deptName);

         Worker worker1 = CreateWorker(department);

         Console.WriteLine();
         Console.Write("How many contracts to this worker? ");
         int num = int.Parse(Console.ReadLine());

         for (int i = 1; i <= num; i++)
         {
            HourContract contract = CreateContract(i);
            worker1.AddContract(contract);
         }

         Console.WriteLine();
         Console.Write("Enter month and year to calculate the income (MM/yyyy): ");
         //DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
         //Console.WriteLine($"Name: {worker1.Name}");
         //Console.WriteLine($"Department: {worker1.Department}");
         //Console.WriteLine($"Income to {date.Month:D2}/{date.Year:D4}: {worker1.Income(date.Year, date.Month):F2}", CultureInfo.InvariantCulture);

         string monthAndYear = (Console.ReadLine());
         int month = int.Parse(monthAndYear.Substring(0, 2));
         int year = int.Parse(monthAndYear.Substring(3));
         Console.WriteLine($"Name: {worker1.Name}");
         Console.WriteLine($"Department: {worker1.Department}");
         Console.WriteLine($"Income to {monthAndYear}: {worker1.Income(year, month):F2}", CultureInfo.InvariantCulture);

      }

      static Worker CreateWorker(Department department)
      {
         Console.WriteLine();
         Console.WriteLine("Enter worker data:");
         Console.Write("Name: ");
         string workerName = Console.ReadLine();
         Console.Write("Level (Junior/MidLevel/Senior): ");
         WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
         Console.Write("Base salry: ");
         double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         return new Worker(workerName, level, salary, department);
      }

      static HourContract CreateContract(int id)
      {
         Console.WriteLine();
         Console.WriteLine($"Enter #{id} contract data:");
         Console.Write("Date (DD/MM/YYYY): ");
         DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
         Console.Write("Value per hour: ");
         double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         Console.Write("Duration (hours): ");
         int hours = int.Parse(Console.ReadLine());

         return new HourContract(date, valueHour, hours);
      }
   }
}
