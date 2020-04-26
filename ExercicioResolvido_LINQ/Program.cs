using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using ExercicioResolvido_LINQ.Entities;

namespace ExercicioResolvido_LINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         // File format: Name,Email,Salary
         string employeesFile = @"~\employees.csv".ParsePath();

         try
         {
            if (File.Exists(employeesFile))
            {
               List<Employee> employees = new List<Employee>();

               using (StreamReader sr = File.OpenText(employeesFile))
               {
                  while (!sr.EndOfStream)
                  {
                     string[] fields = sr.ReadLine().Split(',');

                     string name = fields[0];
                     string email = fields[1];
                     double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                     employees.Add(new Employee(name, email, salary));
                  }

                  foreach (var employee in employees)
                  {
                     Console.WriteLine(employee);
                  }

                  Console.WriteLine();
                  Console.Write("Enter salry reference: ");
                  double reference = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                  Console.WriteLine($"Email of people whose salary is more than {reference.ToString("F2", CultureInfo.InvariantCulture)}");
                  var emailList = employees.Where(p => p.Salary > reference).OrderBy(p => p.Email).Select(p => p.Email);

                  foreach (var email in emailList)
                  {
                     Console.WriteLine(email);
                  }

                  double sum = employees.Where(p => p.Name[0] == 'B').Sum(p => p.Salary);
                  Console.WriteLine();
                  Console.WriteLine($"Sum of salary of people whose name starts with 'B': {sum.ToString("F2", CultureInfo.InvariantCulture)}");

                  sum = employees.Where(p => p.Name[0] == 'E').Sum(p => p.Salary);
                  Console.WriteLine();
                  Console.WriteLine($"Sum of salary of people whose name starts with 'E': {sum.ToString("F2", CultureInfo.InvariantCulture)}");

                  sum = employees.Where(p => p.Name[0] == 'F').Sum(p => p.Salary);
                  Console.WriteLine();
                  Console.WriteLine($"Sum of salary of people whose name starts with 'F': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
               }
            }
            else
            {
               Console.WriteLine($"[ERROR]: file '{employeesFile}' doesn't exist!");
            }
         }
         catch (IOException ex)
         {

         }
         catch (Exception ex)
         {

         }
      }
   }
}
